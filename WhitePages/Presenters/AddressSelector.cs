using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class AddressSelector : Form
    {
        
        private DAL.DataConnector connector;
        private string addressText;
        private string addressId;

        public AddressSelector()
        {
            InitializeComponent();
        }

        public string AddressId
        {
            get { return addressId; }
        }

        public string AddressText
        {
            get { return addressText; }
        }

        public void SetConnected(DAL.DataConnector connector)
        {
            this.connector = connector;
            addressExplorer.SetConnected(connector);
        }

        public void Fill(int zipCode)
        {
            lvAddresses.Items.Clear();
            tbZipCode.Text = zipCode.ToString();
            //string addressParent = connector.GetAddressParent(zipCode);
            List<string[]> addresses = connector.GetAddressNeiborhoods(zipCode); //, addressParent);

            foreach(string[] str in addresses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = str[0];
                item.Tag = str[2];
                item.SubItems.Add(str[1]);
                lvAddresses.Items.Add(item);
            }
        }

        public void Fill(string part)
        {
            lvAddresses.Items.Clear();
            tbAddress.Text = part;
            List<Model.Address> addresses = connector.GetAddressesByPart(part);

            foreach (Model.Address address in addresses)
                lvAddresses.Items.Add(address.ToListViewItem());
        }

        #region ОБработка событий LV
        private void lvAddresses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(addressId))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void lvAddresses_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvAddresses.SelectedItems.Count == 1)
            {
                addressId = lvAddresses.SelectedItems[0].Tag.ToString();
                addressText = lvAddresses.SelectedItems[0].Text + ", " + lvAddresses.SelectedItems[0].SubItems[1].Text;
            }
        }
        #endregion

        #region Обработка событий тулбаров
        private void tsbZip_TextChanged(object sender, System.EventArgs e)
        {
            if (tbZipCode.Text.Length ==6)
            {
                int i = 0;
                if (int.TryParse(tbZipCode.Text, out i))
                    tsbSearchByZip.Enabled = (i > 100000 & i < 999999); 
            }
        }

        private void tbAddress_TextChanged(object sender, System.EventArgs e)
        {
            tsbSearchByAddress.Enabled = !string.IsNullOrEmpty(tbAddress.Text);
        }

        private void tsbSearchByAddress_Click(object sender, EventArgs e)
        {
            Fill(tbAddress.Text);
        }

        private void tsbSearchByZip_Click(object sender, EventArgs e)
        {
            Fill(int.Parse(tbZipCode.Text));
        }
        #endregion


        //это была несвоевременная идея...
        public class AddressSearchEventArgs : EventArgs
        {
            string AddressId;
            string AddressText;
            string AddressToSearch;
            int ZipCodeToSearch;

            public AddressSearchEventArgs(string addressId, string addressText)
            {
                AddressText = addressText;
                AddressId = addressId;
            }

            public AddressSearchEventArgs(int zipCodeToSearch, string addressToSearch)
            {
                ZipCodeToSearch = zipCodeToSearch;
                AddressToSearch = addressToSearch;
            }
        }

        
    }
}
