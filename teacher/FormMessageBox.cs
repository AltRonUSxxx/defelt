using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class FormMessageBox : Form
    {
        bool isAllowClose;
        public FormMessageBox(string message, string lang)
        {
            TopMost = true;
            isAllowClose = false;
            InitializeComponent();
            label_main.Text = message;
            switch(lang.ToLower())
            {
                case "ru":
                    button_ok.Text = "ОК";
                    break;
                case "en":
                    button_ok.Text = "OK";
                    break;
            }
        }

        Point lastPoint;

        private void FormMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isAllowClose)
            {
                e.Cancel = true;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            isAllowClose = true;
            this.Close();
        }

        async private void FormMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            Thread.Sleep(10);
        }

        async private void FormMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            Thread.Sleep(10);
        }
    }
}
