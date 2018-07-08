using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace WhitePages.DAL
{
    public class DataConnector
    {
        private LoadingParameters lastLoadingPArameters = new LoadingParameters();
        readonly object stateLock = new object();
        int timeout = 15;

        /// <summary>
        /// Событие, вызываемое, когда состояние внутреннего подключения к БД изменяется
        /// </summary>
        public event EventHandler<StateChangeEventArgs> StateChange;

        /// <summary>
        /// Событие, вызываемое сразу после выполнения запроса к БД. Создано в целях диагностики.
        /// </summary>
        public event EventHandler RequestCompleted;

        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection
        {
            get { return sqlConnection; }
        }

        public DataConnector() { }

        public void Connect(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
            SqlConnection.StateChange += SqlConnection_StateChange;
            try
            {
                sqlConnection.Open();
                timeout = sqlConnection.ConnectionTimeout;
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка подключения к базе данных!", e);
            }
        }
        
        public void Disonnect()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка подключения к базе данных!", e);
            }
        }

        public override string ToString()
        {
            return sqlConnection.State.ToString() + ": " +
                sqlConnection.DataSource + ":" + sqlConnection.Database;
        }

        private void SqlConnection_StateChange(object sender, StateChangeEventArgs e)
        {
            StateChange?.Invoke(this, e);
        }

        public long Update(long personId, Dictionary<string,string> changedProperties)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_PersonUpdate";
                    foreach (KeyValuePair<string, string> item in changedProperties)
                        cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                    //cmd.Parameters.Add(new SqlParameter("@unit", null));
                    SqlParameter retval = new SqlParameter("@rowAffected", SqlDbType.BigInt);
                    retval.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(retval);

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    long newId = (long)cmd.Parameters["@rowAffected"].Value;
                    RequestCompleted?.Invoke(this, EventArgs.Empty);

                    if (res == 0)
                    {
                        MessageBox.Show("Ошибка выполнения операции с данными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    if (changedProperties["@personId"] == "0")
                        return newId;
                    else
                        return res;
                }
                catch (SqlException e)
                {
                    if (e.Message.Contains("IX_PersonPhones"))
                        MessageBox.Show("В базе данных уже содержится такой номер телефона.\r\nДобавление записи отменено.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        throw e;
                    return 0;
                }
                finally { conn.Close(); }
            }
        }

        public long Update(Model.Person person)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_PersonUpdate";
                    cmd.Parameters.Add(new SqlParameter("@personId", person.PersonId));
                    cmd.Parameters.Add(new SqlParameter("@surName", person.SurName));
                    cmd.Parameters.Add(new SqlParameter("@firstName", person.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@givenName", person.GivenName));
                    cmd.Parameters.Add(new SqlParameter("@phoneNumber", person.PhoneNumber));

                    string addressId = string.Empty;
                    if (person.AddressId != null) addressId = person.AddressId.ToString();
                    cmd.Parameters.Add(new SqlParameter("@addressId", addressId));

                    string dt = person.BirthDate.ToString("dd/MM/yyyy hh:mm:ss");
                    cmd.Parameters.Add(new SqlParameter("@birthDate", dt));
                    cmd.Parameters.Add(new SqlParameter("@address", person.Address));

                    SqlParameter retval = new SqlParameter("@rowAffected", SqlDbType.BigInt);
                    retval.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(retval);

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    long newId = (long)cmd.Parameters["@rowAffected"].Value;
                    RequestCompleted?.Invoke(this, EventArgs.Empty);

                    if (res == 0)
                    {
                        MessageBox.Show("Ошибка выполнения операции с данными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    return newId;
                }
                catch (SqlException e)
                {
                    if (e.Message.Contains("IX_PersonPhones"))
                        MessageBox.Show("В базе данных уже содержится такой номер телефона.\r\nДобавление записи отменено.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        throw e;
                    return 0;
                }
                finally { conn.Close(); }
            }
            
        }

        /// <summary>
        /// Удаляет записи из БД
        /// </summary>
        /// <param name="personIds">Значения первичных ключей</param>
        /// <returns>Количество удаленных записей</returns>
        public int Delete(string[] personIds)
        {
            int res = 0;
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                DataTable table = new DataTable();
                table.Columns.Add("PersonId", typeof(string));
                foreach (string id in personIds)
                    table.Rows.Add(id);

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PersonDelete";
                cmd.Parameters.Add(new SqlParameter("@personIds", table));
                res = cmd.ExecuteNonQuery();
                RequestCompleted?.Invoke(this, EventArgs.Empty);

                if (res == 0)
                    MessageBox.Show("Ошибка выполнения операции с данными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            return res;
        }

        #region пробуем загрузить в потоке...
        /// <summary>
        /// Загрузка данных из БД в отдельном потоке
        /// </summary>
        /// <param name="start"></param>
        /// <param name="windowSize"></param>
        /// <param name="searchArgs"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public void LoadInThread( int start, int windowSize,
                SearchArgs searchArgs)
        {
            lastLoadingPArameters = new LoadingParameters(start, windowSize, searchArgs);
            Thread workload = new Thread(new ThreadStart(Load));
            workload.IsBackground = true;
            workload.Start();
        }

        //делегат для передачи вызова по окончании загрузки
        public event LoadingEventHandler LoadingFinished;
        public delegate void LoadingEventHandler(object sender, LoadingEventArgs e);
        public class LoadingEventArgs : EventArgs
        {
            public LoadingParameters Parameters;

            public LoadingEventArgs(LoadingParameters parameters)
            {
                this.Parameters = parameters;
            }
        }

        private void OnLoadingCompete()
        {
            LoadingFinished?.Invoke(this, new LoadingEventArgs(lastLoadingPArameters));
        }
        
        public void Load()
        {
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                MethodInvoker loadingCompleteDelegate = new MethodInvoker(OnLoadingCompete);
                LoadingParameters localTarget = new LoadingParameters();
                lock (stateLock)
                    localTarget = lastLoadingPArameters;

                List<Model.Person> data = new List<Model.Person>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PersonsGetPaged";
                cmd.Parameters.Add(new SqlParameter("@surName", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.SurName)));
                cmd.Parameters.Add(new SqlParameter("@firstName", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.FirstName)));
                cmd.Parameters.Add(new SqlParameter("@givenName", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.GivenName)));
                cmd.Parameters.Add(new SqlParameter("@phoneNumber", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.PhoneNumber)));
                cmd.Parameters.Add(new SqlParameter("@birthDate", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.BirthDate)));
                cmd.Parameters.Add(new SqlParameter("@address", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.Address)));
                cmd.Parameters.Add(new SqlParameter("@addressExt", SearchArgs.ToValueOrDbNull(localTarget.SearchArgs.AddressExtention)));
                cmd.Parameters.Add(new SqlParameter("@start", localTarget.Start));
                cmd.Parameters.Add(new SqlParameter("@windowSize", localTarget.WindowSize));

                SqlParameter retval = new SqlParameter("@res", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(retval);
                SqlParameter cmdtext = new SqlParameter("@cmd", SqlDbType.Int);
                cmdtext.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(cmdtext);
                try
                {
                    conn.Open();
                    lock (stateLock)
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                localTarget.Count = (int)reader.GetValue(0);
                            if (reader.NextResult())
                            {
                                while (reader.Read())
                                {
                                    localTarget.result.Add(new Model.Person(
                                        (long)reader.GetSqlInt64(0),
                                        reader.GetSqlString(1).ToString(),
                                        reader.GetSqlString(2).ToString(),
                                        reader.GetSqlString(3).ToString(),
                                        (long)reader.GetSqlInt64(4),
                                        (DateTime)reader.GetSqlDateTime(5),
                                        (!reader.IsDBNull(10) ? reader.GetSqlValue(10) : null),
                                        (!reader.IsDBNull(6) ? reader.GetSqlString(6).ToString() : String.Empty),
                                        (!reader.IsDBNull(12) ? reader.GetSqlString(12).ToString() : String.Empty),
                                        (!reader.IsDBNull(11) ? reader.GetSqlString(11).ToString() : String.Empty)));
                                }
                            }
                            reader.Close();
                        }
                    }
                    lastLoadingPArameters = localTarget;
                }
                catch (SqlException e)
                {
                    if (e.Number == -2)
                        MessageBox.Show("Превышено время ожидания ответа от сервера. " +
                            "Сервер не отвечает, либо задан слишком широкий критерий для отбора записей! "
                            , "Ошибка получения данных", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                    loadingCompleteDelegate.Invoke();
                }
            }
        }
        #endregion


        /// <summary>
        /// Загружает данные из БД
        /// </summary>
        /// <param name="start">Начиная с записи номер</param>
        /// <param name="windowSize">Количество загружаемых записей</param>
        /// <param name="searchArgs">Аргументы для поиска</param>
        /// <param name="count">Переменная для возврата счетчика записей</param>
        /// <returns>Список загруженных персон</returns>
        public List<Model.Person> Load(int start, int windowSize, 
                SearchArgs searchArgs, out int count)
        {
            count = 0;
            List<Model.Person> data = new List<Model.Person>();

            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PersonsGetPaged";
                cmd.Parameters.Add(new SqlParameter("@surName", SearchArgs.ToValueOrDbNull(searchArgs.SurName)));
                cmd.Parameters.Add(new SqlParameter("@firstName", SearchArgs.ToValueOrDbNull(searchArgs.FirstName)));
                cmd.Parameters.Add(new SqlParameter("@givenName", SearchArgs.ToValueOrDbNull(searchArgs.GivenName)));
                cmd.Parameters.Add(new SqlParameter("@phoneNumber", SearchArgs.ToValueOrDbNull(searchArgs.PhoneNumber)));
                cmd.Parameters.Add(new SqlParameter("@birthDate", SearchArgs.ToValueOrDbNull(searchArgs.BirthDate)));
                cmd.Parameters.Add(new SqlParameter("@address", SearchArgs.ToValueOrDbNull(searchArgs.Address)));
                cmd.Parameters.Add(new SqlParameter("@addressExt", SearchArgs.ToValueOrDbNull(searchArgs.AddressExtention)));
                cmd.Parameters.Add(new SqlParameter("@start", start));
                cmd.Parameters.Add(new SqlParameter("@windowSize", windowSize));

                SqlParameter retval = new SqlParameter("@res", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(retval);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        RequestCompleted?.Invoke(this, EventArgs.Empty);
                        if (reader.Read())
                            count = (int)reader.GetValue(0);

                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                data.Add(new Model.Person(
                                    (long)reader.GetSqlInt64(0),
                                    reader.GetSqlString(1).ToString(),
                                    reader.GetSqlString(2).ToString(),
                                    reader.GetSqlString(3).ToString(),
                                    (long)reader.GetSqlInt64(4),
                                    (DateTime)reader.GetSqlDateTime(5),
                                    (!reader.IsDBNull(10) ? reader.GetSqlValue(10) : null),
                                    (!reader.IsDBNull(6) ? reader.GetSqlString(6).ToString() : String.Empty),
                                    (!reader.IsDBNull(12) ? reader.GetSqlString(12).ToString() : String.Empty),
                                    (!reader.IsDBNull(11) ? reader.GetSqlString(11).ToString() : String.Empty)));
                            }
                        }
                        reader.Close();
                    }
                }
                catch (SqlException e)
                {
                    if (e.Number == -2)
                        MessageBox.Show("Превышено время ожидания ответа от сервера. " +
                            "Сервер не отвечает, либо задан слишком широкий критерий для отбора записей! "
                            , "Ошибка получения данных", MessageBoxButtons.OK);
                }
                finally { conn.Close(); }
            }
            return data;
        }

        /// <summary>
        /// Закрыть соединение
        /// </summary>
        internal void Close()
        {
            sqlConnection.Close();
        }

        public Model.Person Load(Model.Person data)
        {
            Model.Person person = null;
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_PersonGet";
                    cmd.Parameters.Add(new SqlParameter("@personId", data.PersonId));
                    
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            person = new Model.Person(
                                (long)reader.GetSqlInt64(0),
                                reader.GetSqlString(1).ToString(),
                                reader.GetSqlString(2).ToString(),
                                reader.GetSqlString(3).ToString(),
                                (long)reader.GetSqlInt64(4),
                                (DateTime)reader.GetSqlDateTime(5),
                                (!reader.IsDBNull(10) ? reader.GetSqlValue(10) : null),
                                (!reader.IsDBNull(6) ? reader.GetSqlString(6).ToString() : String.Empty),
                                (!reader.IsDBNull(12) ? reader.GetSqlString(12).ToString() : String.Empty),
                                (!reader.IsDBNull(11) ? reader.GetSqlString(11).ToString() : String.Empty));
                        }
                        reader.Close();
                        RequestCompleted?.Invoke(this, EventArgs.Empty);
                        return person;
                    }
                }
                catch (Exception e) {return null;}
                finally { conn.Close(); }
            }
        }


        #region Методы для работы с адресами
        public Model.Address Load(Model.Address data)
        {
            Model.Address address = null;
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AddressGet";
                cmd.Parameters.Add(new SqlParameter("@addressId", data.AddressId));

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        address = new Model.Address(
                                    reader.GetSqlValue(0),
                                    reader.GetSqlString(1).ToString(),
                                    (int)reader.GetSqlInt32(2),
                                    reader.IsDBNull(3) ? 0 : (int)reader.GetSqlInt32(3),
                                    reader.IsDBNull(4) ? 0 : (int)reader.GetSqlInt32(4),
                                    reader.IsDBNull(5) ? 0 : (int)reader.GetSqlInt32(5),
                                    (Model.Address.NumberingEnum)(int)(reader.IsDBNull(6) ? 0 : reader.GetSqlInt16(6)),
                                    0,
                                    reader.GetSqlString(7).ToString());
                    }
                    reader.Close();
                }
                conn.Close();
                RequestCompleted?.Invoke(this, EventArgs.Empty);
            }
            return address;
        }

        //public long Update(Model.Address address)
        //{
            //using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            //{
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = conn;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "sp_PersonUpdate";
            //        cmd.Parameters.Add(new SqlParameter("@personId", person.PersonId));
            //        cmd.Parameters.Add(new SqlParameter("@surName", person.SurName));
            //        cmd.Parameters.Add(new SqlParameter("@firstName", person.FirstName));
            //        cmd.Parameters.Add(new SqlParameter("@givenName", person.GivenName));
            //        cmd.Parameters.Add(new SqlParameter("@phoneNumber", person.PhoneNumber));

            //        string addressId = string.Empty;
            //        if (person.AddressId != null) addressId = person.AddressId.ToString();
            //        cmd.Parameters.Add(new SqlParameter("@addressId", addressId));

            //        string dt = person.BirthDate.ToString("dd/MM/yyyy hh:mm:ss");
            //        cmd.Parameters.Add(new SqlParameter("@birthDate", dt));
            //        cmd.Parameters.Add(new SqlParameter("@address", person.Address));

            //        SqlParameter retval = new SqlParameter("@rowAffected", SqlDbType.BigInt);
            //        retval.Direction = ParameterDirection.Output;
            //        cmd.Parameters.Add(retval);

            //        conn.Open();
            //        int res = cmd.ExecuteNonQuery();
            //        long newId = (long)cmd.Parameters["@rowAffected"].Value;
            //        RequestCompleted?.Invoke(this, EventArgs.Empty);

            //        if (res == 0)
            //        {
            //            MessageBox.Show("Ошибка выполнения операции с данными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return 0;
            //        }
            //        return newId;
            //    }
            //    catch (SqlException e)
            //    {
            //        if (e.Message.Contains("IX_PersonPhones"))
            //            MessageBox.Show("В базе данных уже содержится такой номер телефона.\r\nДобавление записи отменено.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        else
            //            throw e;
            //        return 0;
            //    }
            //    finally { conn.Close(); }
            //}

        //}

        /// <summary>
        /// Загружает из БД коллекцию адресов для данного адреса 
        /// </summary>
        /// <param name="parentId">Идентификатор адреса, для которого осуществляется поиск</param>
        /// <returns>Лист экземпляров дочерних адресов</returns>
        public List<Model.Address> Load(object parentId)
        {
            List<Model.Address> res = new List<Model.Address>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AddressGetChilds";
            cmd.Parameters.Add(new SqlParameter("@parent", parentId == null ? string.Empty : parentId.ToString()));

            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            res.Add(
                                new Model.Address(
                                    reader.GetSqlValue(0),
                                    reader.GetSqlString(1).ToString(),
                                    (int)reader.GetSqlInt32(2),
                                    reader.IsDBNull(3) ? 0 : (int)reader.GetSqlInt32(3),
                                    reader.IsDBNull(4) ? 0 : (int)reader.GetSqlInt32(4),
                                    reader.IsDBNull(5) ? 0 : (int)reader.GetSqlInt32(5),
                                    (Model.Address.NumberingEnum)(int)(reader.IsDBNull(6) ? 0 : reader.GetSqlInt16(6)),
                                    reader.IsDBNull(7) ? 0 : (int)reader.GetSqlInt32(7),
                                    reader.GetSqlString(8).ToString()));
                        }
                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Ошибка чтения из базы данных функции " + cmd.CommandText + "\r\n" + e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// Удаляет запись из справочника адресов БД
        /// </summary>
        /// <param name="personIds">Экземпляр удаляемого адреса</param>
        /// <returns>Количество удаленных записей. -1 = удаление не выполнено, есть связанные записи</returns>
        public int Delete(Model.Address address)
        {
            int res = 0;
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_AddressDelete";
                cmd.Parameters.Add(new SqlParameter("@addressId", address.AddressId));
                res = cmd.ExecuteNonQuery();
                RequestCompleted?.Invoke(this, EventArgs.Empty);

                if (res == 0)
                    MessageBox.Show("Ошибка выполнения операции с данными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            return res;
        }

        public List<string[]> GetAddressNeiborhoods(int zipCode)
        {
            List<string[]> res = new List<string[]>();

            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_GetAddressNeiborhoodsByZipCode";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@zipCode", zipCode));
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] str = new string[3];
                        str[0] = reader.GetSqlInt32(2).ToString();
                        str[1] = reader.GetSqlString(1).ToString().Replace("  ,", "");
                        if (str[1] == "")
                            str[1] = "Отделение связи " + str[0];
                        str[2] = reader.GetSqlValue(0).ToString();
                        res.Add(str);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            return res;
        }

        public int GetAddressNeiborhoodsCount(int zipCode)
        {
            int res = 0;

            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_GetAddressNeiborhoodsCount";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@zipCode", zipCode));
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        res = (int)reader.GetSqlInt32(0);
                    reader.Close();
                }
                conn.Close();
            }
            return res;
        }

        /// <summary>
        /// Перечень адресов найденных по началу строки адреса
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public List<Model.Address> GetAddressesByPart(string part)
        {
            List<Model.Address> res = new List<Model.Address>();

            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_GetAddressesByAddressPart";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@part", part));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.Address address = new Model.Address(
                            reader.GetSqlValue(0),
                            reader.GetSqlString(1).ToString(),
                            (int)reader.GetSqlInt32(2),
                            reader.IsDBNull(3) ? 0 : (int)reader.GetSqlInt32(3),
                            reader.IsDBNull(4) ? 0 : (int)reader.GetSqlInt32(4),
                            reader.IsDBNull(5) ? 0 : (int)reader.GetSqlInt32(5),
                            reader.IsDBNull(6) ? Model.Address.NumberingEnum.Any : (Model.Address.NumberingEnum)(int)reader.GetSqlInt16(6),
                            reader.IsDBNull(7) ? 0 : (int)reader.GetSqlInt32(7),
                            reader.GetSqlString(8).ToString());

                        res.Add(address);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return res;

        }
        #endregion

        public AutoCompleteStringCollection GetSuggestions(SuggestionSource source)
        {
            AutoCompleteStringCollection res = new AutoCompleteStringCollection();
            using (SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@type", (int)source));
                cmd.CommandText = "[sp_NamePartsGet]";

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    RequestCompleted?.Invoke(this, EventArgs.Empty);
                    while (reader.Read())
                        res.Add(reader.GetSqlValue(0).ToString());
                    reader.Close();
                }
                conn.Close();
            }
            return res;
        }

        public enum SuggestionSource
        {
            SurName = 0,
            FirstName = 1,
            GivenName = 2,
            FullName = 3,
            ShortName = 4
        }

        public  struct LoadingParameters
        {
            public int Start { get; set; }
            public int WindowSize { get; set; }
            public SearchArgs SearchArgs { get; set; }
            public int Count { get; set; }
            public List<Model.Person> result { get; set; }
            public string Query { get; set; }

            public LoadingParameters(int start, int windowSize,
                SearchArgs searchArgs)
            {
                Start = start;
                WindowSize = windowSize;
                SearchArgs = searchArgs;
                Count = 0;
                result = new List<Model.Person>();
                Query = string.Empty;
            }
        }
    }
}
