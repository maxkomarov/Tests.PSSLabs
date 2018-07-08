using System.ComponentModel;
using System.Windows.Forms;

namespace WhitePages.UI.Controls
{
    public partial class NumberingStyle : UserControl
    {
        public NumberingStyle()
        {
            InitializeComponent();
            Value = Model.Address.NumberingEnum.Any;
        }

        [Bindable(true)]
        public Model.Address.NumberingEnum Value
        {
            get
            {
                if (rbSideAny.Checked) return Model.Address.NumberingEnum.Any;
                if (rbSideEven.Checked) return Model.Address.NumberingEnum.Even;
                return Model.Address.NumberingEnum.Odd;
            }
            set
            {
                if (value == Model.Address.NumberingEnum.Any) rbSideAny.Checked = true;
                else if (value == Model.Address.NumberingEnum.Even) rbSideEven.Checked = true;
                else rbSideOdd.Checked = true;
            }
        }
    }
}
