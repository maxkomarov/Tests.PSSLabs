using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.Model
{
    [Bindable(true)]
    public class Person: INotifyPropertyChanged, ICloneable, IEquatable<Person>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private long personId = 0;
        private string surName = string.Empty;
        private string firstName = string.Empty;
        private string givenName = string.Empty;
        private long phoneNumber = 0;
        private DateTime birthDate = new DateTime(1900, 1, 1);
        private string address = string.Empty;
        private object addressId;
        private string fullAddress = string.Empty;
        private string streetAddress = string.Empty;

        private Random rnd;
        private Person originalData;


        public long PersonId
        {
            get { return personId; }
            set { personId = value; OnPropertyChanged("PersonId"); }
        }

        public string SurName
        {
            get { return surName; }
            set { surName = value; OnPropertyChanged("SurName"); }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }

        public string GivenName
        {
            get { return givenName; }
            set { givenName = value; OnPropertyChanged("GivenName"); }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        public object AddressId
        {
            get { return addressId; }
            set { addressId = value; OnPropertyChanged("AddressId"); }
        }

        public string Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("Address"); }
        }

        public string FullAddress
        {
            get { return fullAddress; }
            set { fullAddress = value;  }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string FullName
        {
            get {return surName + " " + firstName + " " + givenName;}
        }

        //используется для биндинга в форме с MaskedTextBox
        public string BirthDateString
        {
            get { return birthDate.ToShortDateString(); }
            set
            {
                try
                {
                    BirthDate = DateTime.Parse(value);
                }
                catch (Exception e)
                {
                    throw new Exception("Предоставленное значение [" + value.ToString() +
                        " ] не является допустимым значением даты");
                }
            }
        }

        public bool FilledOut
        {
            get
            {
                return (!string.IsNullOrEmpty(surName) &&
                        !string.IsNullOrEmpty(firstName) &&
                        !string.IsNullOrEmpty(givenName) &&
                        !(phoneNumber == 0) &&
                        !(birthDate == new DateTime(1900, 1, 1)));
            }
        }

        public bool Changed
        {
            get { return this != originalData; }
        }

        public Person()
        {
            personId = 0;
        }

        public Person(Person fromPerson, bool saveOriginal)
        {
            personId = fromPerson.personId;
            surName = fromPerson.surName;
            firstName = fromPerson.firstName;
            givenName = fromPerson.givenName;
            phoneNumber = fromPerson.phoneNumber;
            birthDate = fromPerson.birthDate;
            addressId = fromPerson.addressId;
            address = fromPerson.address;
            fullAddress = fromPerson.fullAddress.Replace(", ,", ", "); ;
            streetAddress = fromPerson.streetAddress;

            if (saveOriginal)
               originalData = new Person(this, false);
        }

        public Person(long personId, string surName, string firstName, string givenName,
            long phoneNumber, DateTime birthDate, object addressId, string address, string fullAddress, string streetAddress)
        {

            this.surName = surName;
            this.firstName = firstName;
            this.givenName = givenName;
            this.personId = personId;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.addressId = addressId;
            this.address = address;
            this.fullAddress = fullAddress.Replace(", ,", ", ");
            this.streetAddress = streetAddress;

            originalData = new Person(this, false);
        }

        public Person(long personId, NameGenerator.FullName fullname, long phoneNumber, DateTime birthDate, string address)
        {
            this.personId = personId;
            surName = fullname.SurName;
            firstName = fullname.FirstName;
            givenName = fullname.GivenName;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.address = address;

            originalData = new Person(this, false);
        }

        public Person(string values)
        {
            try
            {
                personId = 0;

                string[] parts = values.Split('\t');
                surName = parts[0].Trim().Split(' ')[0].Trim();
                firstName = parts[0].Trim().Split(' ')[1].Trim();
                givenName = parts[0].Trim().Split(' ')[2].Trim();
                phoneNumber = long.Parse(parts[1].Trim());
                if (parts.Length > 2)
                    address = parts[2].Trim();
                else
                    address = string.Empty;

                originalData = new Person(this, false);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception("Данные имеют некорректный формат. Невозможно инициализировать новый экземпляр данных", ex);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (!Equals(originalData))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static ListViewItem ToListViewItem(Person person)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = person.PersonId.ToString();
            item.Name = person.PersonId.ToString();
            item.Text = person.FullName;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Tag = "@phoneNumber", Text = String.Format("{0:(000) 000-00-00}", person.PhoneNumber) });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Tag = "@birthDate", Text = person.BirthDate.ToShortDateString() });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Tag = "@address", Text = (person.FullAddress + ", " + person.Address) });
            item.ImageIndex = 0;
            return item;
        }

        /// <summary>
        /// Проверяет, является ли экземпляр пустым
        /// </summary>
        /// <param name="person">Проверяемый экземпляр</param>
        /// <returns></returns>
        public static bool IsEmpty(Person person)
        {
            if (person == null)
                return true;
            return (string.IsNullOrEmpty(person.SurName) &&
                    string.IsNullOrEmpty(person.FirstName) &&
                    string.IsNullOrEmpty(person.GivenName) &&
                    (person.PhoneNumber == 0) &&
                    string.IsNullOrEmpty(person.Address) &&
                    (person.BirthDate == new DateTime(1900, 1, 1)) &&
                    //(person.ZipCode == 0) &&
                    (person.PersonId == 0));
        }

        /// <summary>
        /// Проверяет минимальную заполненность полей, достаточных для сохранения в БД
        /// </summary>
        /// <param name="person">Проверяемый экземпляр</param>
        /// <returns></returns>
        public static bool IsValid(Person person)
        {
            return (!string.IsNullOrEmpty(person.SurName) &&
                    !string.IsNullOrEmpty(person.FirstName) &&
                    !string.IsNullOrEmpty(person.GivenName) &&
                    !(person.PhoneNumber == 0) &&
                    string.IsNullOrEmpty(person.Address) &&
                    (person.BirthDate > new DateTime(1900, 1, 1)));// &&
                    //(person.ZipCode > 100000));
        }



        /// <summary>
        /// Преобразует текст в список экземпляров класса 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Текст, в котором каждая строка представляет разделенную на поля табуляцией запись </returns>
        public static List<Person> ToPersonList(string text)
        {
            List<Person> res = new List<Person>();
            string[] lines = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
                res.Add(new Model.Person(line));
            return res;
        }

        /// <summary>
        /// Переопределение стандартного метода. Возвращает текстовое представление экземпляра
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName + "\t" + String.Format("{0:(000) 000-00-00}", phoneNumber) + "\t" + address;
        }

        /// <summary>
        /// Возвращает представление экземпляра в виде экземпляра ListViewItem
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        public static List<ListViewItem> ToListViewItems(List<Person> persons)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (Person person in persons)
                list.Add(ToListViewItem(person));
            return list;
        }

        public static Person GetRandom()
        {
            Random rnd = new Random();
            return GetRandom(ref rnd);
        }

        public static Person GetRandom(ref Random rnd)
        {
            if (rnd == null)
                rnd = new Random();

            Person person = new Person();
            NameGenerator.FullName name = NameGenerator.GetFullName(NameGenerator.GenderEnum.UnknownOrAny);

            person.SurName = name.SurName;
            person.FirstName = name.FirstName;
            person.GivenName = name.GivenName;

            char[] nums = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] phone = new char[10];
            phone[0] = nums[rnd.Next(0, 9)];
            for (int i = 0; i < 9; i++)
                phone[i+1] = nums[rnd.Next(0, 9)];
            person.PhoneNumber = long.Parse(new string(phone));
            person.BirthDate = new DateTime(rnd.Next(1900, 2017), rnd.Next(1, 12), rnd.Next(1, 27));
            person.Address = NameGenerator.GetStreetName(rnd) + "., д." + rnd.Next(1, 100) + ", кв." + rnd.Next(1, 350);
            person.originalData = new Person(person, false);
            return person;
        }

        public void Random()
        {
            if (rnd == null)
                rnd = new System.Random();

            NameGenerator.FullName name = NameGenerator.GetFullName(NameGenerator.GenderEnum.UnknownOrAny);

            SurName = name.SurName;
            FirstName = name.FirstName;
            GivenName = name.GivenName;

            char[] nums = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] phone = new char[10];
            phone[0] = nums[rnd.Next(0, 9)];
            for (int i = 0; i < 9; i++)
                phone[i + 1] = nums[rnd.Next(0, 9)];
            PhoneNumber = long.Parse(new string(phone));
            BirthDate = new DateTime(rnd.Next(1900, 2017), rnd.Next(1, 12), rnd.Next(1, 27));
            Address = NameGenerator.GetStreetName(rnd) + "., д." + rnd.Next(1, 100) + ", кв." + rnd.Next(1, 350);
        }

        /// <summary>
        /// Имплементация интерфейса ICloneable
        /// </summary>
        /// <returns>Клон текущего экземпляра</returns>
        public object Clone()
        {
            return new Person(this, true);
        }

        /// <summary>
        /// Делает текущий экземпляр клоном образца
        /// </summary>
        /// <param name="clone">Экземпляр образца</param>
        public void CloneFrom(Person clone)
        {
            if (clone == null)
                throw new Exception("Невозможно клонизовать экземпляр, равный null.");
            PersonId = clone.PersonId;
            SurName = clone.SurName;
            FirstName = clone.FirstName;
            GivenName = clone.GivenName;
            BirthDate = clone.BirthDate;
            PhoneNumber = clone.PhoneNumber;
            Address = clone.Address;
        }

        public bool Equals(Person other)
        {
            if (other == null)
                return false;
            return (
                PersonId == other.PersonId &&
                SurName == other.SurName &&
                FirstName == other.FirstName &&
                GivenName == other.GivenName &&
                BirthDate == other.BirthDate &&
                PhoneNumber == other.PhoneNumber &&
                Address == other.Address);
        }

        public static bool operator == (Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
                return true;

            if (ReferenceEquals(person1, null))
                return false;

            if (ReferenceEquals(person2, null))
                return false;

            return person1.personId == person2.personId 
                & person1.surName.Equals(person2.surName)
                && person1.firstName.Equals(person2.firstName)
                && person1.phoneNumber == person2.phoneNumber
                && person1.birthDate.Equals(person2.birthDate)
                && person1.address.Equals(person2.address)
                && person1.addressId.Equals(person2.addressId);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
