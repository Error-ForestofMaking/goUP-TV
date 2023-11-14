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

namespace goUP_TV
{
    public partial class offscreen : Form
    {
        int lit = 100;
        int ct = 0;

        public offscreen()
        {
            InitializeComponent();
        }

        private void offscreen_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm");
            label2.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (label2.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (label2.Size.Height / 2 + 300));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm");
            label2.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (label2.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (label2.Size.Height / 2 + 300));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*timer.Enabled = false;

            label2.Visible = false;
            label1.Visible = false;
            menu_panel.Visible = false;
            this.BackColor = Color.Black;

            label2.Font = new Font("맑은 고딕", 200, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Text = "goUP TV";
            label2.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (label2.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (label2.Size.Height / 2));
            label2.Location = new Point(label2.Location.X, label2.Location.Y - 80);
            label2.Visible = true;

            label1.Font = new Font("맑은 고딕", 100);
            label1.ForeColor = Color.White;
            label1.Text = "0%";
            label1.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (label1.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (label1.Size.Height / 2));
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 200);
            label1.Visible = true;

            close_timer.Enabled = true;*/

            this.Close();
        }

        private void offscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                e.Handled = true;
        }

        private void d_bt_Click(object sender, EventArgs e)
        {
            if (lit >= 25)
            {
                lit = lit - 20;
            }

            label2.ForeColor = Color.FromArgb(lit, lit, lit);
        }

        private void u_bt_Click(object sender, EventArgs e)
        {
            if (lit <= 230)
            {
                lit = lit + 20;
            }

            label2.ForeColor = Color.FromArgb(lit, lit, lit);
        }

        private void zzz_bt_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Black)
            {
                this.BackColor = Color.FromArgb(100, 70, 30);
            }
            else
            {
                this.BackColor = Color.Black;
            }
        }

        private void close_timer_Tick(object sender, EventArgs e)
        {
            if (ct > 99)
            {
                this.Close();
            }
            else
            {
                ct = ct + 1;

                label1.Text =  ct + "%";
                label1.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (label1.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (label1.Size.Height / 2));
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 200);
            }
        }
    }
}
