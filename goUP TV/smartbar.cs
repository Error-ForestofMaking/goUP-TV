using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace goUP_TV
{
    public partial class smartbar : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public smartbar()
        {
            InitializeComponent();
        }

        private void close_Load(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 213, 10);
            //this.Size = new Size(50, 50);

            int ro = 60;

            time.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, time.Width, time.Height, ro, ro));
            hide_bt.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, hide_bt.Width, hide_bt.Height, ro, ro));
            home_bt.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, home_bt.Width, home_bt.Height, ro, ro));
            keybord_bt.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, keybord_bt.Width, keybord_bt.Height, ro, ro));

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));
        }

        private void time_timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss");

            Process[] processList = Process.GetProcessesByName("Whale");
            if (processList.Length > 0)
            {
                home_bt.Visible = true;
            }
            else
            {
                home_bt.Visible = false;
            }
        }

        private void show_bt_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 213, 10);
        }

        private void hide_bt_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 213, -80);
        }

        private void nowapp_bt_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("Whale");
            for (int i = processList.Length - 1; i >= 0; i--)
            {
                processList[i].CloseMainWindow();
            }
        }

        private void smartbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                e.Handled = true;
        }

        private void time_Click(object sender, EventArgs e)
        {
            offscreen f = new offscreen();
            f.Show();
        }

        private void keybord_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processList = Process.GetProcessesByName("osk");
                if (processList.Length > 0)
                {
                    processList[0].Kill();
                }
                else
                {
                    Process p = new Process();

                    p.StartInfo.FileName = @"C:\Windows\System32\osk.exe";
                    p.StartInfo.Arguments = null;

                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

                    p.Start();
                }
            }
            catch { }
        }
    }
}
