using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class Persons : UserControl
    {
        bool queryForDataAllowed = false;
        SortedList<char, char> alphabet = new SortedList<char, char>();
        DAL.DataConnector connector;

        public Persons()
        {
            InitializeComponent();
            searchPane.Width = 150;
            personPane.Width = 18;
        }

        public void GetConnected(ref DAL.DataConnector connector)
        {
            this.connector = connector;
           queryForDataAllowed =
           !(connector.SqlConnection.State == System.Data.ConnectionState.Closed
           || connector.SqlConnection.State == System.Data.ConnectionState.Broken);

            personsPane.RefreshToolbarState(queryForDataAllowed);
            personPane.RefreshToolbarState(queryForDataAllowed);
            personsPane.RefreshPagerState(personsPane.Start, personsPane.WindowSize, 0);

            tsbExport.Enabled = tsbImport.Enabled = queryForDataAllowed;

            LoadInThread(0, 50, new SearchArgs());

            searchPane.SearchRequested += SearchPane_SearchRequested;
            searchPane.ClearResultsRequested += SearchPane_ClearResultsRequested;
            connector.StateChange += Connector_StateChange;
            connector.LoadingFinished += Connector_LoadingFinished;

            GetDataForCombos();
        }

        #region Загрузка данных для LV и комбиков в PersonPane
        //public int RefreshData(int start, int windowSize, SearchArgs searchArgs)
        //{
        //    Cursor = Cursors.WaitCursor;
        //    if (!searchArgs.IsEmpty)
        //        windowSize = 0;
        //    int count = 0;
        //    searchPane.SearchEnabled = false;
        //    personsPane.StartLoadingMeter(connector.SqlConnection.ConnectionTimeout, 100);
        //    List<Model.Person> data = connector.Load(start, windowSize, searchArgs, out count);
        //    personsPane.Refresh(Model.Person.ToListViewItems(data).ToArray());
        //    personsPane.RefreshPagerState(personsPane.Start, personsPane.WindowSize, count);
        //    Cursor = Cursors.Default;
        //    return count;
        //}

        private void LoadInThread(int start, int windowSize, SearchArgs searchArgs)
        {
            personsPane.StartLoadingMeter(connector.SqlConnection.ConnectionTimeout * 100, 100);
            connector.LoadInThread(start, windowSize, searchArgs);
        }

        private void GetDataForCombos()
        {
            personPane.PopulateComboBoxes(
                    connector.GetSuggestions(DAL.DataConnector.SuggestionSource.FirstName),
                    connector.GetSuggestions(DAL.DataConnector.SuggestionSource.GivenName),
                    connector.GetSuggestions(DAL.DataConnector.SuggestionSource.SurName));
        }

        private void Connector_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            queryForDataAllowed =
               !(connector.SqlConnection.State == System.Data.ConnectionState.Closed
               || connector.SqlConnection.State == System.Data.ConnectionState.Broken);
            tsbExport.Enabled = tsbImport.Enabled = queryForDataAllowed;
        }

        private delegate void UpdatePersonsDelegate(DAL.DataConnector.LoadingParameters parameters);

        //Это когда коннектор закончил загрузку в потоке
        private void Connector_LoadingFinished(object sender, DAL.DataConnector.LoadingEventArgs e)
        {
            if (InvokeRequired)
                BeginInvoke(new UpdatePersonsDelegate(UpdatePersons), e.Parameters);
            else
            {
                personsPane.Refresh(Model.Person.ToListViewItems(e.Parameters.result).ToArray());
                personsPane.RefreshPagerState(personsPane.Start, personsPane.WindowSize, e.Parameters.Count);
                searchPane.SearchEnabled = true;
                personsPane.StopLoadingMeter();
                Cursor = Cursors.Default;
            }
        }

        void UpdatePersons (DAL.DataConnector.LoadingParameters parameters)
        {
            personsPane.Refresh(Model.Person.ToListViewItems(parameters.result).ToArray());
            personsPane.RefreshPagerState(personsPane.Start, personsPane.WindowSize, parameters.Count);
            searchPane.SearchEnabled = true;
            personsPane.StopLoadingMeter();
            Cursor = Cursors.Default;
        }

        public void RegisterFormMainMenu(MenuStrip menu)
        {
            menu.AllowMerge = true;
            menuStrip1.AllowMerge = true;
            ToolStripManager.Merge(menuStrip1, menu);
        }
        #endregion

        #region Обработка событий панели поиска
        private void SearchPane_ClearResultsRequested(object sender, EventArgs e)
        {
            personsPane.StartLoadingMeter(connector.SqlConnection.ConnectionTimeout * 100, 100);
            connector.LoadInThread(personsPane.Start, 0, new SearchArgs());
        }

        private void SearchPane_SearchRequested(object sender, SearchEventArgs e)
        {
            if (!e.Args.IsSubSearch)
                LoadInThread(personsPane.Start, 0, e.Args);
            else
                personsPane.SearchFor(e.Args);
        }
        #endregion

        #region Обработка событий панели грида.
        private void Persons_PersonsRefreshRequested(object sender, PersonsPane.PersonListEventArgs e)
        {
            LoadInThread(e.Start, e.WindowSize, new SearchArgs());
        }

        private void Persons_PersonsPasteRequested(object sender, PersonsPane.PersonListEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Persons_PersonsDragDropped(object sender, PersonsPane.PersonListEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Persons_PersonsDeletionRequested(object sender, PersonsPane.PersonListEventArgs e)
        {
            int deleted = connector.Delete(e.SelectedItemKeys);
            if (deleted > 0)
                personsPane.OnDeleted(e.SelectedItemKeys);
        }

        private void Persons_SelectedPersonsListChanged(object sender, PersonsPane.PersonListEventArgs e)
        {
            if (e.SelectedItemKeys.Length == 1)
            {
                Cursor = Cursors.WaitCursor;
                Model.Person data = new Model.Person(); ;
                long personId = long.Parse(e.SelectedItemKeys[0]);
                if (personId > 0)
                {
                    data.PersonId = personId;
                    data = connector.Load(data);
                    personPane.Fill(data, e.SelectedItemKeys[0].ToString());
                }
                personPane.ShowOrHide(true);
                Cursor = Cursors.Default;
            }
            //else
                //вызываем с пустышкой для очистки
                //personPane.Fill(null, string.Empty);
        }
        #endregion

        #region Обработка событий формы записи
        //Обновляем или создаем запись через коннектор и запрашиваем обновление листа
        private void personPane_UpdateRequested(object sender, PersonPane.EditingEventArgs e)
        {
            string key = e.Person.PersonId.ToString();
            if (connector.Update(e.Person) > 0)
                personsPane.OnUpdated(Model.Person.ToListViewItem(e.Person));
        }

        //Удаляем запись через коннектор и запрашиваеим обновление листа
        private void personPane_DeleteRequested(object sender, PersonPane.EditingEventArgs e)
        {
            string key = e.Person.PersonId.ToString();
            if (connector.Delete(new string[] { key }) > 0)
            {
                personsPane.OnDeleted(new string[] { key });
                personPane.OnDeleted();
            }
        }

        private void personPane_AddressRequested(object sender, PersonPane.EditingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.AddressRequested) & e.ZipCodeRequested > 100000)
                GetAddressByZipCode(e.ZipCodeRequested);
            else if (!string.IsNullOrEmpty(e.AddressRequested))
                GetAddressByAddressPart(e.AddressRequested);

        }
        #endregion

        #region Работа со справочником адресов
        void GetAddressByZipCode(int zipCode)
        {
            if (connector.GetAddressNeiborhoodsCount(zipCode) > 1)
            {
                AddressSelector form = new AddressSelector();
                form.SetConnected(connector);
                form.Fill(zipCode);
                if (form.ShowDialog() == DialogResult.OK)
                    personPane.OnAddressResolved(form.AddressId, form.AddressText);
            }
        }

        void GetAddressByAddressPart(string part)
        {
            AddressSelector form = new AddressSelector();
            form.SetConnected(connector);
            form.Fill(part);
            if (form.ShowDialog() == DialogResult.OK)
                personPane.OnAddressResolved(form.AddressId, form.AddressText);
        }

        private void tsbAddressExplorer_Click(object sender, EventArgs e)
        {
            UI.AddressExplorer addressExplorer = new UI.AddressExplorer();
            addressExplorer.SetConnected(connector);
            addressExplorer.ShowDialog();
        }
        #endregion

        #region Всякое от импорт/экспорта
        private void ImportText(string text)
        {
            try
            {
                foreach (Model.Person person in Model.Person.ToPersonList(text))
                {
                    long id = connector.Update(person);
                    if (id > 0)
                    {
                        person.PersonId = id;
                        personsPane.Add(new ListViewItem[] { Model.Person.ToListViewItem(person) });
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ImportData()
        {
            if (ofdImport.ShowDialog() == DialogResult.OK)
            {
                string[] parts = ofdImport.FileName.Split('.');
                Array.Reverse(parts);
                if (parts[0] == "txt")
                {
                    //Читаем из tab-delemited файла
                    string text = string.Empty;
                    try
                    {
                        //Это надо переносить в отдельный поток. Жалко, что тут нет бэк.уокера
                        ImportText(File.ReadAllText(ofdImport.FileName, Encoding.Default));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка чтения из файла!\r\n" + ex.Message);
                    }
                }

            }
        }

        //public void ExportData()
        //{
        //    if (sfdExport.ShowDialog() == DialogResult.OK)
        //    {
        //        if (lvpersonsPane.SelectedItems.Count == 0)
        //            File.WriteAllText(sfdExport.FileName, ListViewItemsToText(lvpersonsPane.Items.GetEnumerator()));
        //        else
        //            File.WriteAllText(sfdExport.FileName, ListViewItemsToText(lvpersonsPane.SelectedItems.GetEnumerator()));
        //    }
        //}

        private void tsbImport_Click(object sender, EventArgs e)
        {
            ImportData();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зис фанкшн но йет имплементд.\r\nСорри, чэпс...");
        }

        private void tsbMainPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                ImportText(Clipboard.GetText());
        }
        #endregion

    }
}
