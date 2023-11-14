using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goUP_TV
{
    public partial class main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,      // x-coordinate of upper-left corner
            int nTopRect,       // y-coordinate of upper-left corner
            int nRightRect,     // x-coordinate of lower-right corner
            int nBottomRect,    // y-coordinate of lower-right corner   
            int nWidthEllipse,  // height of ellipse
            int nHeightEllipse  // width of ellipse  
        );

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            smartbar f = new smartbar();
            f.Show();

            //MessageBox.Show("실행중인 디버그 버전 : 2", "goUP TV SB관리자");

            //둥글게 시작
            int ro = 80;

            sc_panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, sc_panel.Width, sc_panel.Height, 60, 60));

            live_panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, live_panel.Width, live_panel.Height, ro, ro));
            app.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app.Width, app.Height, ro, ro));

            live1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, live1.Width, live1.Height, ro, ro));
            live2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, live1.Width, live1.Height, ro, ro));

            app_1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            app_9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            video_1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            video_2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));

            spo_1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            spo_2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, app_1.Width, app_1.Height, ro, ro));
            //둥글게 끝
        }

        private void sc_bt_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.justwatch.com/kr/검색?q=" + textBox.Text;

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void live1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://onair.imbc.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void live2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://onair.imbc.com/?chid=14";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void live4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://sports.news.naver.com/kbaseball/index";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_1_Click(object sender, EventArgs e)
        {

        }

        private void app_2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.netflix.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.disneyplus.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://tv.apple.com/kr";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.tving.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://watcha.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.wavve.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.coupangplay.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void app_9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://serieson.naver.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void spo_1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://sports.news.naver.com/wfootball/index";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void spo_2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://www.spotvnow.co.kr";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void video_1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://youtube.com";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void video_2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.link = "https://twitch.tv";

            string pathToWeblinkExecutable = "C:\\Program Files\\Naver\\Naver Whale\\Application\\whale.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo(pathToWeblinkExecutable);
            startInfo.Arguments = $"--kiosk {Properties.Settings.Default.link}";

            Process.Start(startInfo);
        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                MessageBox.Show("확인을 누르면 goUP TV가 종료됩니다", "goUP TV");
                Application.Exit();
            }

            if (e.Control && e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("확인을 누르면 goUP TV가 종료됩니다", "goUP TV");
                Application.Exit();
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = @"C:\Windows\System32\osk.exe";
            p.StartInfo.Arguments = null;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            p.Start();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {

        }

        bool opened = true;

        private void app_Click(object sender, EventArgs e)
        {
            if (opened == true)
            {
                am_open.Enabled = false;
                am_close.Enabled = true;
            }
            else
            {
                am_open.Enabled = true;
                am_close.Enabled = false;
            }
        }

        private void am_close_Tick(object sender, EventArgs e)
        {
            if (live_panel.Location.Y < -380)
            {
                am_close.Enabled = false;
                live_panel.Location = new Point(55, -400);
                app.Location = new Point(0, 135);
                app.Size = new Size(1920, 942);
                opened = false;
            }
            else
            {
                live_panel.Location = new Point(55, live_panel.Location.Y - 10);
                app.Location = new Point(0, app.Location.Y - 6);
                app.Size = new Size(1920, app.Size.Height + 6);
            }
        }

        private void am_open_Tick(object sender, EventArgs e)
        {
            if (live_panel.Location.Y > 115)
            {
                am_open.Enabled = false;
                live_panel.Location = new Point(55, 135);
                app.Location = new Point(0, 450);
                app.Size = new Size(1920, 630);
                opened = true;
            }
            else
            {
                live_panel.Location = new Point(55, live_panel.Location.Y + 10);
                app.Location = new Point(0, app.Location.Y + 6);
                app.Size = new Size(1920, app.Size.Height - 6);
            }
        }
    }
}
