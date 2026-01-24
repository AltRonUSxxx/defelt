using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class authorization : Form
    {
        bool allowClose = false;
        string language = "ru";
        public authorization()
        {
            InitializeComponent();
            setLanguage();

            BackgroundWorker Taskmgr_killer = new BackgroundWorker();
            Taskmgr_killer.DoWork += Taskmgr_killer_DoWork;
            Taskmgr_killer.RunWorkerAsync();
        }

        private void Taskmgr_killer_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker Taskmgr_killer = sender as BackgroundWorker;
            while (!Taskmgr_killer.CancellationPending)
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    if (process.ProcessName.ToLower().Contains("taskmgr"))
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch
                        {

                        }
                    }
                }
            }

        }
        private void setLanguage()
        {
            switch (language)
            {
                case "ru":
                    button_login.Text = "Войти";
                    break;
                case "en":
                    button_login.Text = "Login";
                    break;
            }
        }
        private void alarmClose()
        {
            switch (language)
            {
                case "ru":
                    MessageBox.Show("Программу нельзя закрыть");
                    break;
                case "en":
                    MessageBox.Show("You can't close this app");
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            alarmClose();
        }

        Point lastPoint;
        private void pictureBox_uppestPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            Thread.Sleep(10);
        }

        private void pictureBox_uppestPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            Thread.Sleep(10);
        }

        private void authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!allowClose)
            {
                e.Cancel = true;
                alarmClose();
            }
        }

        private void authorization_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("es");
        }

        private void authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.F15)
            {
                allowClose = !allowClose;
            }
        }
    }
}
