using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class PersonPane : UserControl
    {

        public event PersonEditingEventHandler CreateNewRequested;
        public event PersonEditingEventHandler DeleteRequested;
        public event PersonEditingEventHandler UpdateRequested;
        public event PersonEditingEventHandler GenerateRandomRequested;
        public event PersonEditingEventHandler DataObjectChanged;
        public event PersonEditingEventHandler DataObjectCanBeSaved;
        public event PersonEditingEventHandler AddressRequested;

        public delegate void PersonEditingEventHandler(object sender, EditingEventArgs e);

        bool queryForDataAllowed = false;

        private Model.Person data;
        string editingItemKey = "0";
        int initialWidth = 200;

        public Model.Person Data
        {
            get { return data; }
        }

        public string EditingItemKey
        {
            get { return editingItemKey; }
        }

        public PersonPane()
        {
            InitializeComponent();
            pDetails.Visible = false;
            cbSurName.MaxLength =
                cbGivenName.MaxLength =
                cbSurName.MaxLength =
                Properties.Settings.Default.NamesFieldsLength;
            data = new Model.Person();

        }

        public void Fill(Model.Person data, string editingItemKey)
        {
            if (data != null && !string.IsNullOrEmpty(editingItemKey))
            {
                this.data = data;

                foreach (Control ctrl in pDetails.Controls)
                    ctrl.DataBindings.Clear();

                cbSurName.DataBindings.Add("Text", Data, "SurName");
                cbSurName.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                cbFirstName.DataBindings.Add("Text", Data, "FirstName");
                cbFirstName.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                cbGivenName.DataBindings.Add("Text", Data, "GivenName");
                cbGivenName.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbPhoneNumber.DataBindings.Add("Text", Data, "PhoneNumber");
                mtbPhoneNumber.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                mtbBirthDate.DataBindings.Add("Text", Data, "BirthDateString");
                mtbBirthDate.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                tbAddress.DataBindings.Add("Text", Data, "FullAddress");

                tbAddressExt.DataBindings.Add("Text", Data, "Address");
                tbAddressExt.DataBindings["Text"].DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                this.editingItemKey = editingItemKey;
                mtbZipCode.Text = "";

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
                tbAddress.Text = string.Empty;
                tbAddressExt.Text = string.Empty;
                cbFirstName.Text = string.Empty;
                cbGivenName.Text = string.Empty;
                cbSurName.Text = string.Empty;
                mtbPhoneNumber.Text = string.Empty;
            }
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

        public void RefreshToolbarState(bool queryForDataAllowed)
        {
            this.queryForDataAllowed = queryForDataAllowed;
            tsbNew.Enabled = queryForDataAllowed;
            tsbGenerate.Enabled = queryForDataAllowed;
        }

        public void OnDeleted()
        {
            Clear();
            RefreshToolbarState(queryForDataAllowed);
        }

        public void PopulateComboBoxes(AutoCompleteStringCollection firstNames,
                                       AutoCompleteStringCollection givenNames,
                                       AutoCompleteStringCollection surnames)
        {
            cbSurName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbGivenName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbSurName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbGivenName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbFirstName.AutoCompleteCustomSource = firstNames;
            cbGivenName.AutoCompleteCustomSource = givenNames;
            cbSurName.AutoCompleteCustomSource = surnames;

        }

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

        protected virtual void OnGenerateRandomRequested()
        {
            GenerateRandomRequested?.Invoke(this, new EditingEventArgs(Data));
        }

        protected virtual void OnDataObjectChanged(int editingItemIndex)
        {
            DataObjectChanged?.Invoke(this, new EditingEventArgs(editingItemIndex));
        }

        protected virtual void OnDataObjectCanBeSaved(int editingItemIndex)
        {
            DataObjectCanBeSaved?.Invoke(this, new EditingEventArgs(editingItemIndex));
        }

        protected virtual void OnAddressRequested(EditingEventArgs e)
        {
            AddressRequested?.Invoke(this, e);
        }


        public void OnAddressResolved(string addressId, string addressText)
        {
            tbAddress.Text = addressText;
            data.AddressId = addressId;
        }
        #endregion

        #region Обработка событий тулбаров

        private void tsbGenerate_Click(object sender, EventArgs e)
        {
            Generate();
            tsbSave.Enabled = queryForDataAllowed & true;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            cbSurName.DataBindings["Text"].WriteValue();
            cbFirstName.DataBindings["Text"].WriteValue();
            cbGivenName.DataBindings["Text"].WriteValue();
            mtbPhoneNumber.DataBindings["Text"].WriteValue();
            mtbBirthDate.DataBindings["Text"].WriteValue();
            tbAddressExt.DataBindings["Text"].WriteValue();
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

        private void Data_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            tsbSave.Enabled = true & queryForDataAllowed;
        }

        private void mtbZipCode_TextChanged(object sender, EventArgs e)
        {
            if (mtbZipCode.Text.Length == 6)
            {
                int i = int.Parse(mtbZipCode.Text);
                if (i > 100000 & i < 999999)
                    OnAddressRequested(new EditingEventArgs(i, string.Empty));
            }
        }

        private void tbAddressToSearch_DoubleClick(object sender, EventArgs e)
        {
            OnAddressRequested(new EditingEventArgs(0, tbAddressToSearch.Text));
        }

        #region Методы пользовательских команд
        public void New()
        {
            data = new Model.Person();
            Fill(data, "0");
            Data.PropertyChanged += Data_PropertyChanged;
            pDetails.Enabled = true;
            tsbSave.Enabled = tsbSave.Enabled & queryForDataAllowed;
            OnCreateNewRequested();
        }

        private void Generate()
        {
            if (Data.Changed)
                if (MessageBox.Show("Данные были изменены и при продолжении изменения будут потеряны. Продолжить?", "Требуется подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
            Fill(Model.Person.GetRandom(), "-1");
            Data.PropertyChanged += Data_PropertyChanged;
            pDetails.Enabled = true;
            tsbSave.Enabled = queryForDataAllowed;
            OnGenerateRandomRequested();
        }

        private void Save()
        {
            data.FullAddress = tbAddress.Text;
            OnUpdateRequested();
        }

        private void Delete()
        {
            if (data.PersonId == 0)
                Clear();
            else
                OnDeleteRequested();
        }

        #endregion

        #region Класс PersonEditingEventArgs для передачи данных в событиях к родителю
        public class EditingEventArgs : EventArgs
        {
            public int EditingItemIndex { get; set; }
            public Model.Person Person { get; set; }
            public int ZipCodeRequested { get; set; }
            public string AddressRequested { get; set; }

            public EditingEventArgs(int editingItemIndex)
            {
                EditingItemIndex = editingItemIndex;
            }

            public EditingEventArgs(Model.Person person)
            {
                Person = person;
            }

            public EditingEventArgs(Model.Person person, int editingItemIndex)
            {
                Person = person;
                EditingItemIndex = editingItemIndex;
            }

            public EditingEventArgs (int zipCodeRequested, string addressRequested)
            {
                AddressRequested = addressRequested;
                ZipCodeRequested = zipCodeRequested;
            }
        }
        #endregion

    }
}
