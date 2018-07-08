using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.Presenters
{
    public partial class NewAddressBar : UserControl
    {
        int index;

        public NewAddressBar()
        {
            InitializeComponent();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbAddress.Text.Contains(","))
            {
                string[] parts = tbAddress.Text.Split(',');
                if (index == 0)
                {
                    int i = 0;
                    if (!int.TryParse(parts[0], out i))
                        MessageBox.Show("Ввод адреса должен начинаться с шести цифр индекса. Разделяйте части адреса запятой");
                }
            }
            else
            {
                int i = 0;
                if (!int.TryParse(tbAddress.Text, out i))
                    MessageBox.Show("Ввод адреса должен начинаться с шести цифр индекса. Разделяйте части адреса запятой", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (i <= 999999)
                    {
                        //Здесь надо либо ждать все 6 цифр,
                        //либо начать подбирать по округлению индекса
                        //но это даст обращение к базе на каждую цифру, что не хорошо
                    }
                    else
                    {
                        MessageBox.Show("Индекс не может иметь больше шести цифр. Закончите ввод индекса запятой", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbAddress.Text = tbAddress.Text.Replace(tbAddress.Text.Substring(6, 1), ", ");
                        tbAddress.SelectionStart = tbAddress.Text.Length - 1;
                        tbAddress.SelectionLength = 0;
                    }
                }
            }

        }

        private void Parse(string[] parts)
        {

        }
    }
}
