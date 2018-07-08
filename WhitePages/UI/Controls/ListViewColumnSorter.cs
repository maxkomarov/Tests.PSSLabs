using System;
using System.Collections;
using System.Windows.Forms;

namespace WhitePages.UI.Controls
{
    public class ListViewColumnSorter : IComparer
    {
        public string timeFormat { set; get; }
        private int columnToSort;
        private SortOrder orderOfSort;

        public int SortColumn
        {
            set { columnToSort = value; }
            get { return columnToSort; }
        }

        public SortOrder Order
        {
            set { orderOfSort = value; }
            get { return orderOfSort; }
        }
        private CaseInsensitiveComparer objectCompare;

        public ListViewColumnSorter()
        {
            columnToSort = 0;
            orderOfSort = SortOrder.None;
            objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int res = -1;
            res = String.Compare(((ListViewItem)x).SubItems[columnToSort].Text,
                                    ((ListViewItem)y).SubItems[columnToSort].Text);
            if (orderOfSort == SortOrder.Descending)
                res *= -1;
            return res;
        }
    }
}
