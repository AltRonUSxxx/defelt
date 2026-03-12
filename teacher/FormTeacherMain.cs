using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class FormTeacherMain : Form
    {
        public FormTeacherMain()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            panel_register_new_student.Visible = false;
            makeSquareCorner();
        }

        private void hideAllPanels()
        {
            panel_register_new_student.Visible=false;
            panel_register_new_student.Location = new System.Drawing.Point(-368, 33);

            panel_groups.Visible = false;
            panel_groups.Location = new System.Drawing.Point(-368, 33);

        }

        private void disableAllButtons()
        {
            disableButton(button_groups);
            disableButton(button_register_new_student);
        }

        Point lastPoint;
        async private void pictureBox_uppestPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            Thread.Sleep(10);
        }

        async private void pictureBox_uppestPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            Thread.Sleep(10);
        }

        private void makeSquareCorner()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int r = 15;
                Rectangle bounds = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

                path.AddArc(bounds.X, bounds.Y, r * 2, r * 2, 180, 90);
                path.AddLine(bounds.X + r, bounds.Y, bounds.Right - r, bounds.Y);
                path.AddArc(bounds.Right - r * 2, bounds.Y, r * 2, r * 2, 270, 90);
                path.AddLine(bounds.Right, bounds.Y + r, bounds.Right, bounds.Bottom - r);
                path.AddArc(bounds.Right - r * 2, bounds.Bottom - r * 2, r * 2, r * 2, 0, 90);
                path.AddLine(bounds.Right - r, bounds.Bottom, bounds.X + r, bounds.Bottom);
                path.AddArc(bounds.X, bounds.Bottom - r * 2, r * 2, r * 2, 90, 90);
                path.AddLine(bounds.X, bounds.Bottom - r, bounds.X, bounds.Y + r);

                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private async void show_panel(Panel panel)
        {
            panel.Visible = true;
            int x = panel.Location.X;
            int y = panel.Location.Y;
            while (x <= 216)
            {
                panel.Location = new Point(x, y);
                x += 20;
                await Task.Delay(5);
            }
            panel.Location = new Point(216, y);
        }

        private async void hide_panel(Panel panel)
        {
            panel.Visible = true;
            int x = panel.Location.X;
            int y = panel.Location.Y;
            while (x >= -368)
            {
                panel.Location = new Point(x, y);
                x -= 20;
                await Task.Delay(5);
            }
            panel.Location = new Point(-368, y);
            panel.Visible = false;
        }

        private void disableButton(Button button)
        {
            button.BackColor = Color.Silver;
            button.ForeColor = Color.Black;
        }

        private void enableButton(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private async void button_register_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            disableAllButtons();
            show_panel(panel_register_new_student);
            enableButton(button_register_new_student);
        }

        

        private void button_groups_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            disableAllButtons();
            show_panel(panel_groups);
            enableButton(button_groups);
        }
    }
}
