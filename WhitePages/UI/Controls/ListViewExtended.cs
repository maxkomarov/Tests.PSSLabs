using System;
using System.Collections;
using System.Windows.Forms;

namespace WhitePages.UI.Controls
{
    public class ListViewExtended : ListView
    {
        private int sortColumn = -1;

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                Sorting = SortOrder.Ascending;
            }
            else
            {
                if (Sorting == SortOrder.Ascending)
                    Sorting = SortOrder.Descending;
                else
                    Sorting = SortOrder.Ascending;
            }

            Sort();
            ListViewItemSorter = new ListViewItemComparer(e.Column, Sorting);
            Cursor = Cursors.Default;
        }
    }
    
    public class ListViewItemComparer : IComparer
    {
            private int col;
            private SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
            int res = 0;
            //даты            
            try
            {
                System.DateTime firstDate = DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                System.DateTime secondDate = DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
                res = DateTime.Compare(firstDate, secondDate);
            }
            
            catch //тогда как строки
            {
                res = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
            if (order == SortOrder.Descending)
                res *= -1;
            return res;
        }
        }
}


