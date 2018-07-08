using System;


namespace WhitePages
{
    public delegate void SearchEventHandler (object sender, SearchEventArgs e);

    public struct SearchArgs
    {
        private string surName;
        private string firstName;
        private string givenName;
        private long phoneNumber;
        private DateTime birthDate;
        private string address;
        private string addressExtention;
        private bool isSubSearch;

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string GivenName
        {
            get { return givenName; }
            set { givenName = value; }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string AddressExtention
        {
            get { return addressExtention; }
            set { addressExtention = value; }
        }

        public bool IsSubSearch
        {
            get { return isSubSearch; }
            set { isSubSearch = value; }
        }

        public static SearchArgs Empty
        {
            get
            {
                return new SearchArgs(
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    0,
                    new DateTime(1900,1,1),
                    string.Empty,
                    string.Empty,
                    false);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrEmpty(surName)
                    && string.IsNullOrEmpty(firstName)
                    && string.IsNullOrEmpty(givenName)
                    && string.IsNullOrEmpty(address)
                    && phoneNumber == 0
                    && birthDate < new DateTime(1900, 1, 2);
            }
                
        }

        public SearchArgs(
                string surName,
                string firstName,
                string givenName,
                long phoneNumber,
                DateTime birthDate,
                string address,
                string addressExtention,
                bool isSubSearch)
        {
            this.surName = surName;
            this.firstName = firstName;
            this.givenName = givenName;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
            this.address = address;
            this.addressExtention = addressExtention;
            this.isSubSearch = isSubSearch;
        }

        public static object ToValueOrDbNull(DateTime val)
        {
            if (val == new DateTime(1900, 1, 1) || val == new DateTime(1, 1, 1))
                return DBNull.Value;
            else
                return val;
        }

        public static object ToValueOrDbNull(long val)
        {
            if (val == 0)
                return DBNull.Value;
            else
                return val;
        }

        public static object ToValueOrDbNull(string val)
        {
            if (string.IsNullOrEmpty(val))
                return DBNull.Value;
            else
                return val;
        }
    }

    public class SearchEventArgs : EventArgs
    {
        private SearchArgs args;

        public SearchArgs Args
        {
            get { return this.args; }
        }

        public SearchEventArgs(SearchArgs args)
        {
            this.args = args;
        }
    }
}
