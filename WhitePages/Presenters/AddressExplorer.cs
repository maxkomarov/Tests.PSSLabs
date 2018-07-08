using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class AddressExplorer : UserControl
    {
        DAL.DataConnector connector;

        public AddressExplorer()
        {
            InitializeComponent();
        }

        public void SetConnected(DAL.DataConnector connector)
        {
            this.connector = connector;

            TreeNode rootNode = new TreeNode("Справочник адресов", 1, 1);
            tvAddresses.Nodes.Add(rootNode);
            LoadTree(rootNode, null);
            rootNode.Expand();
            addressPane.RefreshToolbarState(connector.SqlConnection.State == ConnectionState.Open);
            connector.StateChange += Connector_StateChange;

            addressPane.UpdateRequested += AddressPane_UpdateRequested;
            addressPane.CreateNewRequested += AddressPane_CreateNewRequested;
            addressPane.DeleteRequested += AddressPane_DeleteRequested;
        }

        private void AddressPane_DeleteRequested(object sender, AddressPane.EditingEventArgs e)
        {
            if (connector.Delete(e.Address) == -1)
                MessageBox.Show("Невозможно удалить адрес из справочника, поскольку присутствуют подчиненные ему адреса!", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void AddressPane_CreateNewRequested(object sender, AddressPane.EditingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddressPane_UpdateRequested(object sender, AddressPane.EditingEventArgs e)
        {
            //string key = e.Address.AddressId.ToString();
            //if (connector.Update(e.Address) > 0)
            //{
            //    ListViewItem item = e.Address.ToListViewItem(Model.Address.AddressListVewItemStyleEnum.Default);
            //    ListViewItem target = lvAddresses.Items[key];
            //    lvAddresses.SuspendLayout();
            //    if (target != null)
            //    {
            //        int idx = target.Index;
            //        lvAddresses.Items.RemoveByKey(item.Name);
            //        lvAddresses.Items.Insert(idx, item);
            //    }
            //    else
            //        lvAddresses.Items.Insert(0, item);

            //    lvAddresses.SelectedItems.Clear();
            //    item.Selected = true;
            //    ResumeLayout();
            //}
        }

        private void Connector_StateChange(object sender, StateChangeEventArgs e)
        {
            addressPane.RefreshToolbarState(e.CurrentState == ConnectionState.Open);
        }

        private void LoadTree(TreeNode parentNode, object parentId)
        {
            List<Model.Address> addresses = connector.Load(parentId);
            foreach (Model.Address address in addresses)
            {
                TreeNode node = address.ToTreeNode();
                if (address.ChildsCount > 0)
                {
                    parentNode.Nodes.Add(node);
                    LoadTree(node, address.AddressId);
                }
            }
        }

        #region Методы обработки команд пользователя
        
        /// <summary>
        /// Создаем новую запись адреса в БД
        /// </summary>
        /// <param name="parentId">Идентификатор родительского адреса</param>
        /// <returns>Экземпляр созданного адреса</returns>
        private Model.Address New(object parentId)
        {
            Model.Address res = new Model.Address();
            return res;
        }

        /// <summary>
        /// Редактируем запись адреса в БД
        /// </summary>
        /// <param name="addressId">Идентификатор редактируемого адреса</param>
        /// <returns>Отредактированный экземпляр</returns>
        private Model.Address Edit(object addressId)
        {
            Model.Address res = new Model.Address();
            return res;
        }

        /// <summary>
        /// Копируем выделенные в LV адреса в буфер обмена (полный адрес)
        /// </summary>
        private void Copy()
        {

        }

        /// <summary>
        /// Пытаемся вставить данные из буфера обмена как набор адресов
        /// </summary>
        private void Paste()
        {

        }
        #endregion

        #region Обработка событий тулбара
        private void tsbPaste_Click(object sender, EventArgs e)
        {

        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Обработка событий LV
        private void lvAddresses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
               
        }

        private void lvAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAddresses.SelectedItems?.Count == 1)
            {
                addressPane.Fill(connector.Load(new Model.Address(lvAddresses.SelectedItems[0].Name)), lvAddresses.SelectedItems[0].Name, "");
            }
        }
        #endregion

        #region Обработка событий TV
        private void tvAddresses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvAddresses.Items.Clear();
            List<Model.Address> addresses = connector.Load(e.Node.Tag);
            foreach (Model.Address address in addresses)
                lvAddresses.Items.Add(address.ToListViewItem(Model.Address.AddressListVewItemStyleEnum.Default));
        }
        #endregion
    }
}
