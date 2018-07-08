using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class AddressPane : UserControl
    {
        public event EditingEventHandler CreateNewRequested;
        public event EditingEventHandler DeleteRequested;
        public event EditingEventHandler UpdateRequested;
        public event EditingEventHandler DataObjectChanged;
        public event EditingEventHandler DataObjectCanBeSaved;

        public delegate void EditingEventHandler(object sender, EditingEventArgs e);

        bool queryForDataAllowed = false;

        private Model.Address data;
        string editingItemKey = "0";
        int initialWidth = 240;

        public Model.Address Data
        {
            get { return data; }
        }

        public string EditingItemKey
        {
            get { return editingItemKey; }
        }

        public AddressPane()
        {
            InitializeComponent();
            numberingStyle.Value = Model.Address.NumberingEnum.Any;
        }

        public void ShowOrHide(bool visibility)
        {
            if (tsbAutoShow.Checked)
            {
                if (!visibility)
                {
                    initialWidth = Width;
                    Width = tsDetails.Width;
                    pDetails.Visible = false;
                }
                else
                {
                    Width = initialWidth;
                    pDetails.Visible = true;
                }
            }
        }

        #region Обработка событий тулбаров

        private void tsbSave_Click(object sender, EventArgs e)
        {
            tbName.DataBindings["Text"].WriteValue();
            mtbZipCodeBase.DataBindings["Text"].WriteValue();
            mtbZipCodeEnd.DataBindings["Text"].WriteValue();
            mtbBuildingNumberingStart.DataBindings["Text"].WriteValue();
            mtbBuildingNumberingEnd.DataBindings["Text"].WriteValue();
            numberingStyle.DataBindings["Value"].WriteValue();
            Save();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            New();
            tsbSave.Enabled = false;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion

        #region Управление видимостью
        private void tsbShowData_Click(object sender, EventArgs e)
        {
            if (pDetails.Visible)
            {
                initialWidth = Width;
                Width = tsDetails.Width;
                pDetails.Visible = false;
            }
            else
            {
                Width = initialWidth;
                pDetails.Visible = true;
            }
        }

        private void pDetails_VisibleChanged(object sender, EventArgs e)
        {
            tsbShowData.Checked = pDetails.Visible;
        }
        #endregion

        #region Методы для вызова событий
        protected virtual void OnCreateNewRequested()
        {
            CreateNewRequested?.Invoke(this, new EditingEventArgs(Data));
        }

        protected virtual void OnDeleteRequested()
        {
            DeleteRequested?.Invoke(this, new EditingEventArgs(Data));
        }

        protected virtual void OnUpdateRequested()
        {
            UpdateRequested?.Invoke(this, new EditingEventArgs(Data));
        }

        protected virtual void OnDataObjectChanged(int editingItemIndex)
        {
            DataObjectChanged?.Invoke(this, new EditingEventArgs(editingItemIndex));
        }

        protected virtual void OnDataObjectCanBeSaved(int editingItemIndex)
        {
            DataObjectCanBeSaved?.Invoke(this, new EditingEventArgs(editingItemIndex));
        }
        #endregion

        #region Методы пользовательских команд
        public void New()
        {
            data = new Model.Address();
            //Fill(data, "0");
            Data.PropertyChanged += Data_PropertyChanged;
            pDetails.Enabled = true;
            tsbSave.Enabled = tsbSave.Enabled & queryForDataAllowed;
            OnCreateNewRequested();
        }

        private void Save()
        {
            OnUpdateRequested();
        }

        private void Delete()
        {
            if (data.AddressId == null)
                Clear();
            else
                OnDeleteRequested();
        }

        #endregion

        public void Fill(Model.Address data, string editingItemKey, string parentAddress)
        {
            if (data != null && !string.IsNullOrEmpty(editingItemKey))
            {
                this.data = data;

                foreach (Control ctrl in pDetails.Controls)
                    ctrl.DataBindings.Clear();

                tbParentName.DataBindings.Add("Text", Data, "FullName");
                tbParentName.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                tbName.DataBindings.Add("Text", Data, "Name");
                tbName.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbZipCodeBase.DataBindings.Add("Text", Data, "ZipCodeBase");
                mtbZipCodeBase.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbZipCodeEnd.DataBindings.Add("Text", Data, "ZipCodeEnd");
                mtbZipCodeEnd.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbBuildingNumberingStart.DataBindings.Add("Text", Data, "BuildingRangeStart");
                mtbBuildingNumberingStart.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbBuildingNumberingEnd.DataBindings.Add("Text", Data, "BuildingRangeEnd");
                mtbBuildingNumberingEnd.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                if (numberingStyle.DataBindings["Value"] == null)
                {
                    numberingStyle.DataBindings.Add("Value", Data, "Numbering");
                    numberingStyle.DataBindings["value"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
                }

                this.editingItemKey = editingItemKey;
                this.data.PropertyChanged += Data_PropertyChanged;
            }
            else
            {
                Clear();
                ShowOrHide(false);
            }
        }

        private void Clear()
        {
            if (true)
            {
                data = null;
                tbParentName.Text = string.Empty;
                tbName.Text = string.Empty;
                mtbZipCodeBase.Text = string.Empty;
                mtbZipCodeEnd.Text = string.Empty;
                mtbBuildingNumberingStart.Text = string.Empty;
                mtbBuildingNumberingEnd.Text = string.Empty;
                numberingStyle.Value = Model.Address.NumberingEnum.Any;
            }
        }

        public void RefreshToolbarState(bool queryForDataAllowed)
        {
            this.queryForDataAllowed = queryForDataAllowed;
            tsbNew.Enabled = queryForDataAllowed;
        }

        private void Data_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            tsbSave.Enabled = true & queryForDataAllowed;
        }

        #region Класс EditingEventArgs для передачи данных в событиях к родителю
        public class EditingEventArgs : EventArgs
        {
            public int EditingItemIndex { get; set; }
            public Model.Address Address { get; set; }

            public EditingEventArgs(int editingItemIndex)
            {
                EditingItemIndex = editingItemIndex;
            }

            public EditingEventArgs(Model.Address address)
            {
                Address = address;
            }

            public EditingEventArgs(Model.Address address, int editingItemIndex)
            {
                Address = address;
                EditingItemIndex = editingItemIndex;
            }
        }
        #endregion
    }
}
