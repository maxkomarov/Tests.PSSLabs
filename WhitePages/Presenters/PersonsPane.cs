using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class PersonsPane : UserControl
    {
        public delegate void PersonsListEventHandler(object sender, PersonListEventArgs e);
        public event PersonsListEventHandler PersonsListSelectionChanged;
        public event PersonsListEventHandler PersonsDeletionRequested;
        public event PersonsListEventHandler PersonsRefreshRequested;
        public event PersonsListEventHandler PersonsPasteRequested;
        public event PersonsListEventHandler PersonsDragDropped;

        private bool queryForDataAllowed = false;

        private int start = 0;
        private int windowSize = 50;
        private int count = 0;

        public int Start { get { return start; } }
        public int WindowSize { get { return windowSize; } }

        public PersonsPane()
        {
            InitializeComponent();
            tscbWindowSize.SelectedItem = windowSize.ToString();
            tLoading.Tick += TLoading_Tick;
        }


        #region методы
        public void RefreshToolbarState(bool queryForDataAllowed = false)
        {
            this.queryForDataAllowed = queryForDataAllowed;
            RefreshToolbarState();
        }

        private void RefreshToolbarState()
        {
            tsbRefresh.Enabled = tsmiRefresh.Enabled = queryForDataAllowed;
            tsmiSelectAll.Enabled = lvPersons.Items.Count > 0;
            tsbCopy.Enabled = tsmiCopy.Enabled = lvPersons.SelectedItems.Count > 0;
            tsmiPaste.Enabled = Clipboard.ContainsText();
            tsmiDelete.Enabled = tsbDelete2.Enabled = queryForDataAllowed && lvPersons.SelectedItems.Count > 0;
        }

        public void StartLoadingMeter (int maxvalue, int step)
        {
            SuspendLayout();
            tsbGoFirst.Visible = tsbGoLast.Visible = tsbGoNext.Visible =
                tsbGoPrev.Visible = tscbWindowSize.Visible = tslWindowSizeAfter.Visible =
                tslWindowSizeBefore.Visible = tslPagerPosition.Visible = false;

            tspbLoading.Value = 0;
            tspbLoading.Visible = true;
            tspbLoading.Maximum = maxvalue;
            tspbLoading.Step = 10;
            ResumeLayout();
            tLoading.Start();
        }

        public void StopLoadingMeter()
        {
            tsbGoFirst.Visible = tsbGoLast.Visible = tsbGoNext.Visible =
                tsbGoPrev.Visible = tscbWindowSize.Visible = tslWindowSizeAfter.Visible =
                tslWindowSizeBefore.Visible = tslPagerPosition.Visible = true;

            tspbLoading.Visible = false;
            tsPager.Visible = true;
            tspbLoading.Value = 0;
        }

        private void TLoading_Tick(object sender, EventArgs e)
        {
            tspbLoading.PerformStep();
        }

        public void Add(ListViewItem[] items)
        {
            lvPersons.Items.AddRange(items);
        }

        public int Delete(bool supressWarning = false)
        {
            List<string> keys = new List<string>();
            foreach (ListViewItem lvi in lvPersons.SelectedItems)
            {
                //Соответствие типа не проверяем, шансов на несовпадение нет. Хотя и надо бы.
                keys.Add(lvi.Name);
            }

            int c = 0;

            if (keys.Count > 0)
            {
                int firstSelectedIdx = lvPersons.SelectedItems[0].Index;
                if (!supressWarning)
                {
                    if (MessageBox.Show("Будет удалено " + keys.Count.ToString() + " записей. Продолжить?", "Требуется подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        OnPersonsDeleteRequested(new PersonListEventArgs(keys.ToArray()));
                }
                else
                    OnPersonsDeleteRequested(new PersonListEventArgs(keys.ToArray()));
            }

            return c;
        }

        /// <summary>
        /// Копирует выделенные элементы списка в буфер обмена
        /// </summary>
        private void Copy()
        {
            string text = string.Empty;
            foreach (ListViewItem item in lvPersons.SelectedItems)
            {
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    text += (subitem.Text + "\t");
                text += "\r\n";
            }
            Clipboard.SetText(text);
        }


        /// <summary>
        /// Удаляет из LV удаленные из базы элементы
        /// </summary>
        /// <param name="deletedKeys">Ключи удаляемых элементов</param>
        public void OnDeleted(string[] deletedKeys)
        {
            int idx = 0;
            foreach (string key in deletedKeys)
            {
                if (lvPersons.Items[key].Index > idx)
                    idx = lvPersons.Items[key].Index;
                lvPersons.Items.RemoveByKey(key);
            }
            if (lvPersons.Items[idx] != null)
            {
                lvPersons.SelectedItems.Clear();
                lvPersons.Items[idx].Selected = true;
            }
        }


        public void OnUpdated(ListViewItem item)
        {
            StopLoadingMeter();
            ListViewItem target = lvPersons.Items[item.Name];
            if (target != null)
            {
                lvPersons.SuspendLayout();
                int idx = target.Index;
                lvPersons.Items.RemoveByKey(item.Name);
                lvPersons.Items.Insert(idx, item);
            }
            else
                lvPersons.Items.Insert(0, item);

            lvPersons.SelectedItems.Clear();
            item.Selected = true;
        }

        /// <summary>
        /// Заполняет внутренний LV новыми данными
        /// </summary>
        /// <param name="items">Данные</param>
        public void Refresh(ListViewItem[] items)
        {
            tspbLoading.Visible = false;
            Cursor = Cursors.Default;
            lvPersons.Items.Clear();
            lvPersons.Items.AddRange(items);
            tsPager.Enabled = true;
        }

        /// <summary>
        /// Активация указателя после удаления строк
        /// </summary>
        /// <param name="lastSelectedRow">Индекс первой из удаленных строк</param>
        void SelectRow(int lastSelectedRow)
        {
            if (lvPersons.Items.Count > 0)
            {
                lvPersons.SelectedItems.Clear();
                lvPersons.Focus();
                if (lastSelectedRow > 0)
                    lvPersons.Items[lastSelectedRow--].Selected = true;
                else
                    lvPersons.Items[0].Selected = true;
            }
        }

        public void SearchFor(SearchArgs args)
        {
            tsPager.Enabled = false;
            List<int> res = new List<int>();
            foreach (ListViewItem item in lvPersons.Items)
            {
                bool found = true;

                if (!string.IsNullOrEmpty(args.SurName))
                {
                    string[] names = item.SubItems[0].Text.Split(' ');
                    int len = names.Length;

                    for (int i = 0; i < len - 2; i++)
                        found = found & names[i].IndexOf(args.SurName, 0, StringComparison.InvariantCultureIgnoreCase) == 0;

                    if (!string.IsNullOrEmpty(args.FirstName))
                        found = found & names[len - 2].IndexOf(args.FirstName, 0, StringComparison.InvariantCultureIgnoreCase) == 0;
                    if (!string.IsNullOrEmpty(args.GivenName))
                        found = found & names[len - 1].IndexOf(args.GivenName, 0, StringComparison.InvariantCultureIgnoreCase) == 0;
                }

                if (args.PhoneNumber > 0)
                    found = found & item.SubItems[1].Text.Replace("(", "").Replace(")", "").Replace("-", "").IndexOf(args.PhoneNumber.ToString(), 0, StringComparison.InvariantCultureIgnoreCase) == 0;
                if (args.BirthDate > new DateTime(1900,1,1))
                    found = found & item.SubItems[2].Text == args.BirthDate.ToShortDateString();
                if (!string.IsNullOrEmpty(args.Address))
                    found = found & item.SubItems[3].Text.IndexOf(args.Address, 0, StringComparison.InvariantCultureIgnoreCase) >= 0;
                if (!found)
                    lvPersons.Items.RemoveByKey(item.Name);
            }
            RefreshToolbarState();
        }

        #endregion

        #region вспомогательные методы
        private string ListViewItemsToText(System.Collections.IEnumerator items)
        {
            string res = string.Empty;
            while (items.MoveNext())
            {
                ListViewItem item = (ListViewItem)items.Current;
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    res += (subitem.Text + "\t");
                res += "\r\n";
            }
            return res;
        }
        #endregion

        #region  Обработка событий ListView
        private void lvPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshToolbarState();
            if (lvPersons.SelectedItems.Count > 0)
            {
                
                string[] keys = new string[lvPersons.SelectedItems.Count];
                for (int i = 0; i < lvPersons.SelectedItems.Count; i++)
                    keys[i] = lvPersons.SelectedItems[i].Name;

                OnSelectedPersonsListChangted(new PersonListEventArgs(keys));
            }
        }

        private void lvPersons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvPersons.GetItemAt(e.X, e.Y);
            if (item != null)
                OnSelectedPersonsListChangted(new PersonListEventArgs(new string[] { item.Name }));
        }

        private void lvPersons_Resize(object sender, EventArgs e)
        {
            lvPersons.Columns[3].Width = lvPersons.Width - 25 -
                lvPersons.Columns[0].Width -
                lvPersons.Columns[1].Width -
                lvPersons.Columns[2].Width;
        }

        private void lvPersons_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvPersons_DragDrop(object sender, DragEventArgs e)
        {
            OnPersonsDragDropped(new PersonListEventArgs(e.Data.GetData(DataFormats.Text).ToString()));
        }
        #endregion

        #region Обработка событий тулбара
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            OnPersonsRefreshRequested(new PersonListEventArgs());
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                OnPersonsPasteRequested(new PersonListEventArgs());
            else
                MessageBox.Show("Буфер обмена не содержит данных для добавления", "Стоп!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPersons.Items)
                item.Selected = true;
        }
        #endregion

        #region Обработка событий навигатора
        private void tsbGoFirst_Click(object sender, EventArgs e)
        {
            start = 0;
            OnPersonsRefreshRequested(new PersonListEventArgs(start,windowSize));
        }

        private void tsbGoPrev_Click(object sender, EventArgs e)
        {
            if (start > windowSize)
                start = start - windowSize;
            else
                start = 0;
            OnPersonsRefreshRequested(new PersonListEventArgs(start, windowSize));
        }

        private void tsbGoNext_Click(object sender, EventArgs e)
        {
            if (start < (count - windowSize))
                start = start + windowSize;
            OnPersonsRefreshRequested(new PersonListEventArgs(start, windowSize));
        }

        private void tsbGoLast_Click(object sender, EventArgs e)
        {
            start = count / windowSize * windowSize;
            OnPersonsRefreshRequested(new PersonListEventArgs(start, windowSize));
        }

        public void RefreshPagerState(int start, int windowSize, int count)
        {
            tsPager.Enabled = (count > windowSize);
            this.count = count;
            this.start = start;
            tsbGoPrev.Enabled = start >= windowSize;
            tsbGoFirst.Enabled = start >= windowSize;
            tsbGoNext.Enabled = (count > windowSize) & start < (count - windowSize);
            tsbGoLast.Enabled = start < (count - windowSize);
            if (count > (start + windowSize))
                tslPagerPosition.Text = start.ToString() + "-" + (start + windowSize).ToString() + " из " + count.ToString();
            else
                tslPagerPosition.Text = start.ToString() + "-" + count.ToString() + " из " + count.ToString();
        }

        private void tscbWindowSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 50;
            if (int.TryParse(tscbWindowSize.SelectedItem.ToString(), out i))
                windowSize = i;
            start = 0;
            OnPersonsRefreshRequested(new PersonListEventArgs(start, windowSize));
        }
        #endregion

        #region Обработка событий контекстного меню
        private void cmsPersons_Opening(object sender, CancelEventArgs e)
        {
            RefreshToolbarState();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            lvPersons.BeginUpdate();
            foreach (ListViewItem item in lvPersons.Items)
                item.Selected = true;
            lvPersons.EndUpdate();
        }
        #endregion

        #region Методы, вызывающие события

        protected virtual void OnPersonsDeleteRequested(PersonListEventArgs e)
        {
            PersonsDeletionRequested?.Invoke(this, e);
        }

        protected virtual void OnSelectedPersonsListChangted(PersonListEventArgs e)
        {
            PersonsListSelectionChanged?.Invoke(this, e);
        }

        protected virtual void OnPersonsRefreshRequested(PersonListEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            PersonsRefreshRequested?.Invoke(this, e);
        }

        protected virtual void OnPersonsPasteRequested(PersonListEventArgs e)
        {
            PersonsPasteRequested?.Invoke(this, e);
        }

        protected virtual void OnPersonsDragDropped(PersonListEventArgs e)
        {
            PersonsDragDropped?.Invoke(this, e);
        }

        #endregion

        public class PersonListEventArgs : EventArgs
        {
            private string[] selectedItemKeys;
            private string clipboardText;
            private int windowSize = 50;
            private int start = 0;

            public string[] SelectedItemKeys
            {
                get { return selectedItemKeys; }
            }

            public string ClipboardText
            {
                get { return clipboardText; }
            }

            public int WindowSize
            {
                get { return windowSize; }
            }

            public int Start
            {
                get { return start; }
            }

            public PersonListEventArgs(string[] selectedItemKeys)
            {
                this.selectedItemKeys = selectedItemKeys;
            }

            public PersonListEventArgs(string clipboardText)
            {
                this.clipboardText = clipboardText;
            }

            public PersonListEventArgs(int start, int windowSize)
            {
                this.windowSize = windowSize;
                this.start = start;
            }

            public PersonListEventArgs()
            {
                selectedItemKeys = new string[0];
            }

        }
    }
}
