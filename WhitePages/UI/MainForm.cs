using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WhitePages.UI
{
    public partial class MainForm : Form
    {
        DAL.DataConnector connector;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool getConnected()
        {
            if (Properties.Settings.Default.ConnectionString == string.Empty)
            {
                MessageBox.Show("Параметры для подключения к базе данных отсутствуют!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }                
            return true;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (!getConnected())
                Close();
            else
            {
                try
                {
                    connector = new DAL.DataConnector();
                    connector.StateChange += Connector_StateChange;
                    connector.Connect(Properties.Settings.Default.ConnectionString);
                    persons.GetConnected(ref connector);
                    persons.RegisterFormMainMenu(MainMenuStrip);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\nПриложение будет закрыто.\r\n" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
            }
        }

        private void Connector_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            MethodInvoker updateStatusDelegate = new MethodInvoker(UpdateStatus);
            Invoke(updateStatusDelegate);
        }

        void UpdateStatus()
        {
            tsslConnectionStatus.Text = connector.ToString();
        }

        #region Обработка кликов главного меню
        private void tsmiFileExit_Click(object sender, System.EventArgs e)
        {
            connector.Close();
            Close();
        }
        #endregion

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorForm gen = new GeneratorForm(Properties.Settings.Default.ConnectionString);
            gen.ShowDialog();
        }
    }
}
