using System.ComponentModel;
using System.Windows.Forms;

namespace WhitePages.Model
{
    public class Address : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private object addressId;
        private string name;
        private int zipCodeBase;
        private int zipCodeEnd;
        private int buildingRangeStart;
        private int buildingRangeEnd;
        private NumberingEnum numbering;
        private string fullName;
        private int childsCount;

        private Address originalData;

        public object AddressId
        {
            get { return addressId; }
            set { addressId = value; OnPropertyChanged("AddressId"); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public int ZipCodeBase
        {
            get { return zipCodeBase; }
            set { zipCodeBase = value; OnPropertyChanged("ZipCodeBase"); }
        }

        public int ZipCodeEnd
        {
            get { return zipCodeEnd; }
            set { zipCodeEnd = value; OnPropertyChanged("ZipCodeEnd"); }
        }

        public int BuildingRangeStart
        {
            get { return buildingRangeStart; }
            set { buildingRangeStart = value; OnPropertyChanged("BuildingRangeStart"); }
        }

        public int BuildingRangeEnd
        {
            get { return buildingRangeEnd; }
            set { buildingRangeEnd = value; OnPropertyChanged("BuildingRangeEnd"); }
        }

        public NumberingEnum Numbering
        {
            get { return numbering; }
            set { numbering = value; OnPropertyChanged("Numbering"); }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int ChildsCount
        {
            get { return childsCount; }
        }

        /// <summary>
        /// Коснтруктор по умолчанию
        /// </summary>
        public Address() {}

        public Address(object addressId)
        {
            this.addressId = addressId;
        }

        public Address(object addressId, string name, int zipCodeBase, int zipCodeEnd, int buidingRangeStart, int buidingRangeEnd, NumberingEnum numbering, int childsCount, string fullName)
        {
            this.addressId = addressId;

            if (name.Replace(" ", "") == string.Empty)
                name = "Почтовое отделение " + ZipCodeBase.ToString();
            else
                this.name = name;
            this.zipCodeBase = zipCodeBase;
            this.zipCodeEnd = zipCodeEnd;
            this.buildingRangeStart = buidingRangeStart;
            this.buildingRangeEnd = buidingRangeEnd;
            this.numbering = numbering;
            this.fullName = fullName;
            this.childsCount = childsCount;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (!Equals(originalData))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = ZipCodeBase.ToString();
            item.SubItems.Add(fullName);
            item.Tag = addressId;
            return item;
        }

        public ListViewItem ToListViewItem(AddressListVewItemStyleEnum style)
        {
            ListViewItem item = new ListViewItem();
            item.Text = zipCodeBase.ToString();
            item.SubItems.Add(name == null ? "Отделение связи " + zipCodeBase.ToString() : name);
            item.SubItems.Add(zipCodeBase.ToString());
            item.SubItems.Add(zipCodeEnd.ToString());
            item.SubItems.Add(buildingRangeStart > 0 ? buildingRangeStart.ToString() : "Все дома");
            item.SubItems.Add(buildingRangeEnd > 0 ? buildingRangeEnd.ToString() : "Все дома");
            item.SubItems.Add(NumberingEnumToString(numbering));
            item.Tag = addressId;
            item.Name = addressId.ToString();
            return item;
        }

        public static Address Parse(string text)
        {
            Address res = new Address();
            return res;
        }

        public TreeNode ToTreeNode()
        {
            TreeNode res = new TreeNode();
            res.Text = name == null ? "Отделение связи " + zipCodeBase.ToString() : name;
            res.Tag = addressId;
            res.ImageIndex = 0;
            return res;
        }

        public override string ToString()
        {
            return name;
        }

        public string ToFullString()
        {
            return zipCodeBase.ToString() + "," + fullName;
        }

        public enum NumberingEnum
        {
            Any = 0,
            Odd = 1,
            Even = 2
        }

        private string NumberingEnumToString(NumberingEnum value)
        {
            if (value == NumberingEnum.Any) return "Любая";
            if (value == NumberingEnum.Odd) return "Нечетная";
            return "Четная";
        }

        public enum AddressListVewItemStyleEnum
        {
            Default = 0x0,
            ZipCodeBaseFirst = 0x1,
            FullNameAsName = 0x2,
            ZipCodeBaseInFullAddress = 0x4
        }
    }
}
