using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.UI
{
    public partial class AddressExplorer : Form
    {
        public AddressExplorer()
        {
            InitializeComponent();
        }

        public void SetConnected(DAL.DataConnector connector)
        {
            explorer.SetConnected(connector);
        }
    }
}
