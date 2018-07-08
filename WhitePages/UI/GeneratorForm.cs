using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WhitePages.UI
{
    public partial class GeneratorForm : Form
    {
        readonly object stateLock = new object();
        int target = 800000;
        int currentCount = 0;
        int doublesCount = 0;
        DAL.DataConnector connector;
        Thread workload;

        public GeneratorForm()
        {
            InitializeComponent();
        }

        public GeneratorForm(string connectionString)
        {
            InitializeComponent();
            connector = new DAL.DataConnector();
            connector.Connect(connectionString);
            StartThread(this, EventArgs.Empty);
        }

        void StartThread(object sender, EventArgs e)
        {
            workload = new Thread(new ThreadStart(ThreadJob));
            workload.IsBackground = true;
            workload.Start();
        }

        void ThreadJob()
        {
            MethodInvoker updateCounterDelegate = new MethodInvoker(UpdateCount);
            Thread.Sleep(100);

            int localTarget;
            Random rnd = new Random();

            lock (stateLock)
                localTarget = target;

            for (int i = 0; i < localTarget; i++)
            {
                lock (stateLock)
                {
                    currentCount = i;
                    try
                    {
                        connector.Update(Model.Person.GetRandom(ref rnd));
                    }
                    catch (Exception e)
                    {
                        doublesCount++;
                    }
                }
                if (currentCount % 10 == 0)
                    Invoke(updateCounterDelegate);
            }
            connector.Close();
            workload.Abort();
            Close();
        }

        void UpdateCount()
        {
            int tmpCount;
            lock (stateLock)
                tmpCount = currentCount;
            lStatus.Text = "Сгенерировано: " + tmpCount.ToString() + " записей\r\n" +
                "Пропущено " + doublesCount.ToString() + " дубликатов";
        }

        private void GeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            workload.Abort();
            connector.Close();
            Thread.Sleep(100);
        }
    }
}
