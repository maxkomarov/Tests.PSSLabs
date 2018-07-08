using System;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class SearchPane : UserControl
    {
        public event SearchEventHandler SearchRequested;
        public event EventHandler ClearResultsRequested;

        int initialWidth = 200;
        private SearchArgs lastSearchedArgs = SearchArgs.Empty;

        #region Публичные свойства

        public SearchArgs LastSearchedArgs
        {
            get { return lastSearchedArgs; }
        }

        public bool SearchEnabled
        {
            get { return tsbSearchRun.Enabled; }
            set { tsbSearchRun.Enabled = value; }
        }
        #endregion

        public SearchPane()
        {
            InitializeComponent();
            pSearch.Visible = true;
        }

        #region Обработка событий контролов
        protected virtual void OnSearchRequested(SearchArgs args)
        {
            SearchRequested?.Invoke(this, new SearchEventArgs(args));
        }

        private void pSearch_VisibleChanged(object sender, EventArgs e)
        {
            tsbShowSearchPane.Checked = pSearch.Visible;
        }

        private void cbBirthDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBirthDate.Enabled = cbBirthDate.Checked;
        }

        private void tbSurName_TextChanged(object sender, EventArgs e)
        {
            SetButtonsEnabled();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            SetButtonsEnabled();
        }

        private void cbSubsearch_CheckedChanged(object sender, EventArgs e)
        {
            pAddress2.Visible = !cbSubsearch.Checked;
        }

        private void tsbShowSearchPane_Click(object sender, EventArgs e)
        {
            if (pSearch.Visible)
            {
                initialWidth = Width;
                Width = tsSearch.Width;
                pSearch.Visible = false;
            }
            else
            {
                Width = initialWidth;
                pSearch.Visible = true;
            }
        }

        private void tsbSearchRun_Click(object sender, EventArgs e)
        {
            tsbSearchRun.Enabled = false;
            OnSearchRequested();
        }

        private void tsbSearchClear_Click(object sender, EventArgs e)
        {
            tbSurName.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbGivenName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbAddress2.Text = string.Empty;
            mtbPhoneNumber.Text = string.Empty;
            OnClearResultsRequested();
        }
        #endregion

        #region Методы для генерации событий у подписчиков
        protected virtual void OnSearchRequested()
        {
            tsbSearchRun.Enabled = false;
            SearchArgs args = new SearchArgs();
            args.SurName = tbSurName.Text;
            args.FirstName = tbFirstName.Text;
            args.GivenName = tbGivenName.Text;
            args.Address = tbAddress.Text;
            args.AddressExtention = tbAddress2.Text;
            if (cbBirthDate.Checked && (dtpBirthDate.Value != new DateTime(1,1,1))) args.BirthDate = dtpBirthDate.Value;
            if (!string.IsNullOrEmpty(mtbPhoneNumber.Text)) args.PhoneNumber = long.Parse(mtbPhoneNumber.Text);
            lastSearchedArgs = args;
            args.IsSubSearch = cbSubsearch.Checked;

            SearchRequested?.Invoke(this, new SearchEventArgs(args));
        }

        protected virtual void OnClearResultsRequested()
        {
            ClearResultsRequested?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Локальные методы
        void SetButtonsEnabled()
        {
            tsbSearchClear.Enabled = tsbSearchRun.Enabled =
                !(string.IsNullOrEmpty(tbSurName.Text)
                && string.IsNullOrEmpty(tbFirstName.Text)
                && string.IsNullOrEmpty(tbGivenName.Text)
                && string.IsNullOrEmpty(tbAddress.Text)
                && string.IsNullOrEmpty(tbAddress2.Text)
                && string.IsNullOrEmpty(mtbPhoneNumber.Text)
                && !cbBirthDate.Checked);
        }
        #endregion

    }
}
