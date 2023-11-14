namespace goUP_TV
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.am_open = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.Label();
            this.live_panel = new System.Windows.Forms.Panel();
            this.app = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menutitle_1 = new System.Windows.Forms.Label();
            this.sc_panel = new System.Windows.Forms.Panel();
            this.sc_bt = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.am_close = new System.Windows.Forms.Timer(this.components);
            this.app_1 = new System.Windows.Forms.Button();
            this.live1 = new System.Windows.Forms.Button();
            this.live2 = new System.Windows.Forms.Button();
            this.spo_1 = new System.Windows.Forms.Button();
            this.spo_2 = new System.Windows.Forms.Button();
            this.video_2 = new System.Windows.Forms.Button();
            this.app_2 = new System.Windows.Forms.Button();
            this.app_4 = new System.Windows.Forms.Button();
            this.video_1 = new System.Windows.Forms.Button();
            this.app_3 = new System.Windows.Forms.Button();
            this.app_5 = new System.Windows.Forms.Button();
            this.app_9 = new System.Windows.Forms.Button();
            this.app_6 = new System.Windows.Forms.Button();
            this.app_8 = new System.Windows.Forms.Button();
            this.app_7 = new System.Windows.Forms.Button();
            this.live_panel.SuspendLayout();
            this.app.SuspendLayout();
            this.sc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // am_open
            // 
            this.am_open.Interval = 1;
            this.am_open.Tick += new System.EventHandler(this.am_open_Tick);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu.Location = new System.Drawing.Point(30, 20);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(101, 86);
            this.menu.TabIndex = 50;
            this.menu.Text = "홈";
            // 
            // live_panel
            // 
            this.live_panel.AutoScroll = true;
            this.live_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.live_panel.Controls.Add(this.app_1);
            this.live_panel.Controls.Add(this.live1);
            this.live_panel.Controls.Add(this.live2);
            this.live_panel.Location = new System.Drawing.Point(55, 135);
            this.live_panel.Margin = new System.Windows.Forms.Padding(0);
            this.live_panel.Name = "live_panel";
            this.live_panel.Size = new System.Drawing.Size(1810, 265);
            this.live_panel.TabIndex = 53;
            this.live_panel.Click += new System.EventHandler(this.app_Click);
            // 
            // app
            // 
            this.app.Controls.Add(this.spo_1);
            this.app.Controls.Add(this.spo_2);
            this.app.Controls.Add(this.label2);
            this.app.Controls.Add(this.menutitle_1);
            this.app.Controls.Add(this.video_2);
            this.app.Controls.Add(this.app_2);
            this.app.Controls.Add(this.app_4);
            this.app.Controls.Add(this.video_1);
            this.app.Controls.Add(this.app_3);
            this.app.Controls.Add(this.app_5);
            this.app.Controls.Add(this.app_9);
            this.app.Controls.Add(this.app_6);
            this.app.Controls.Add(this.app_8);
            this.app.Controls.Add(this.app_7);
            this.app.Location = new System.Drawing.Point(0, 450);
            this.app.Margin = new System.Windows.Forms.Padding(0);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(1920, 942);
            this.app.TabIndex = 54;
            this.app.Click += new System.EventHandler(this.app_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(12, 768);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = ".";
            // 
            // menutitle_1
            // 
            this.menutitle_1.AutoSize = true;
            this.menutitle_1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menutitle_1.Location = new System.Drawing.Point(48, 20);
            this.menutitle_1.Name = "menutitle_1";
            this.menutitle_1.Size = new System.Drawing.Size(114, 40);
            this.menutitle_1.TabIndex = 14;
            this.menutitle_1.Text = "모든 앱";
            // 
            // sc_panel
            // 
            this.sc_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sc_panel.Controls.Add(this.sc_bt);
            this.sc_panel.Controls.Add(this.textBox);
            this.sc_panel.Location = new System.Drawing.Point(1390, 30);
            this.sc_panel.Name = "sc_panel";
            this.sc_panel.Size = new System.Drawing.Size(475, 65);
            this.sc_panel.TabIndex = 55;
            // 
            // sc_bt
            // 
            this.sc_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sc_bt.FlatAppearance.BorderSize = 0;
            this.sc_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sc_bt.Location = new System.Drawing.Point(407, 0);
            this.sc_bt.Name = "sc_bt";
            this.sc_bt.Size = new System.Drawing.Size(68, 65);
            this.sc_bt.TabIndex = 56;
            this.sc_bt.Text = ">";
            this.sc_bt.UseVisualStyleBackColor = false;
            this.sc_bt.Click += new System.EventHandler(this.sc_bt_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(5, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(393, 39);
            this.textBox.TabIndex = 0;
            this.textBox.Click += new System.EventHandler(this.textBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 56;
            this.label1.Text = "goUP TV 1.4";
            // 
            // am_close
            // 
            this.am_close.Interval = 1;
            this.am_close.Tick += new System.EventHandler(this.am_close_Tick);
            // 
            // app_1
            // 
            this.app_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_1.FlatAppearance.BorderSize = 0;
            this.app_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_1.Image = ((System.Drawing.Image)(resources.GetObject("app_1.Image")));
            this.app_1.Location = new System.Drawing.Point(33, 33);
            this.app_1.Margin = new System.Windows.Forms.Padding(20);
            this.app_1.Name = "app_1";
            this.app_1.Size = new System.Drawing.Size(330, 200);
            this.app_1.TabIndex = 3;
            this.app_1.Text = "goUP OneView";
            this.app_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_1.UseVisualStyleBackColor = false;
            this.app_1.Click += new System.EventHandler(this.app_1_Click);
            // 
            // live1
            // 
            this.live1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.live1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.live1.FlatAppearance.BorderSize = 0;
            this.live1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.live1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.live1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.live1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.live1.Image = ((System.Drawing.Image)(resources.GetObject("live1.Image")));
            this.live1.Location = new System.Drawing.Point(403, 33);
            this.live1.Margin = new System.Windows.Forms.Padding(20);
            this.live1.Name = "live1";
            this.live1.Size = new System.Drawing.Size(330, 200);
            this.live1.TabIndex = 1;
            this.live1.Text = "MBC Live\r\n종합";
            this.live1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.live1.UseVisualStyleBackColor = false;
            this.live1.Click += new System.EventHandler(this.live1_Click);
            // 
            // live2
            // 
            this.live2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.live2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.live2.FlatAppearance.BorderSize = 0;
            this.live2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.live2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.live2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.live2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.live2.Image = ((System.Drawing.Image)(resources.GetObject("live2.Image")));
            this.live2.Location = new System.Drawing.Point(773, 33);
            this.live2.Margin = new System.Windows.Forms.Padding(20);
            this.live2.Name = "live2";
            this.live2.Size = new System.Drawing.Size(330, 200);
            this.live2.TabIndex = 2;
            this.live2.Text = "MBC Every1\r\n예능";
            this.live2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.live2.UseVisualStyleBackColor = false;
            this.live2.Click += new System.EventHandler(this.live2_Click);
            // 
            // spo_1
            // 
            this.spo_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spo_1.FlatAppearance.BorderSize = 0;
            this.spo_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.spo_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.spo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spo_1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.spo_1.Image = global::goUP_TV.Properties.Resources.internet;
            this.spo_1.Location = new System.Drawing.Point(55, 560);
            this.spo_1.Margin = new System.Windows.Forms.Padding(20);
            this.spo_1.Name = "spo_1";
            this.spo_1.Size = new System.Drawing.Size(330, 200);
            this.spo_1.TabIndex = 5;
            this.spo_1.Text = "NAVER Sports\r\n";
            this.spo_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spo_1.UseVisualStyleBackColor = false;
            this.spo_1.Click += new System.EventHandler(this.spo_1_Click);
            // 
            // spo_2
            // 
            this.spo_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spo_2.FlatAppearance.BorderSize = 0;
            this.spo_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.spo_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.spo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spo_2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.spo_2.Image = global::goUP_TV.Properties.Resources.spotv;
            this.spo_2.Location = new System.Drawing.Point(425, 560);
            this.spo_2.Margin = new System.Windows.Forms.Padding(20);
            this.spo_2.Name = "spo_2";
            this.spo_2.Size = new System.Drawing.Size(330, 200);
            this.spo_2.TabIndex = 18;
            this.spo_2.Text = "SPOTV NOW";
            this.spo_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spo_2.UseVisualStyleBackColor = false;
            this.spo_2.Click += new System.EventHandler(this.spo_2_Click);
            // 
            // video_2
            // 
            this.video_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.video_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.video_2.FlatAppearance.BorderSize = 0;
            this.video_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.video_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.video_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.video_2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.video_2.Image = ((System.Drawing.Image)(resources.GetObject("video_2.Image")));
            this.video_2.Location = new System.Drawing.Point(1535, 320);
            this.video_2.Margin = new System.Windows.Forms.Padding(20);
            this.video_2.Name = "video_2";
            this.video_2.Size = new System.Drawing.Size(330, 200);
            this.video_2.TabIndex = 13;
            this.video_2.Text = "Twitch";
            this.video_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.video_2.UseVisualStyleBackColor = false;
            this.video_2.Click += new System.EventHandler(this.video_2_Click);
            // 
            // app_2
            // 
            this.app_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_2.FlatAppearance.BorderSize = 0;
            this.app_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_2.Image = ((System.Drawing.Image)(resources.GetObject("app_2.Image")));
            this.app_2.Location = new System.Drawing.Point(55, 80);
            this.app_2.Margin = new System.Windows.Forms.Padding(20);
            this.app_2.Name = "app_2";
            this.app_2.Size = new System.Drawing.Size(330, 200);
            this.app_2.TabIndex = 4;
            this.app_2.Text = "Netflix";
            this.app_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_2.UseVisualStyleBackColor = false;
            this.app_2.Click += new System.EventHandler(this.app_2_Click);
            // 
            // app_4
            // 
            this.app_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_4.FlatAppearance.BorderSize = 0;
            this.app_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_4.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_4.Image = ((System.Drawing.Image)(resources.GetObject("app_4.Image")));
            this.app_4.Location = new System.Drawing.Point(795, 80);
            this.app_4.Margin = new System.Windows.Forms.Padding(20);
            this.app_4.Name = "app_4";
            this.app_4.Size = new System.Drawing.Size(330, 200);
            this.app_4.TabIndex = 6;
            this.app_4.Text = "Apple TV+";
            this.app_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_4.UseVisualStyleBackColor = false;
            this.app_4.Click += new System.EventHandler(this.app_4_Click);
            // 
            // video_1
            // 
            this.video_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.video_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.video_1.FlatAppearance.BorderSize = 0;
            this.video_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.video_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.video_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.video_1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.video_1.Image = ((System.Drawing.Image)(resources.GetObject("video_1.Image")));
            this.video_1.Location = new System.Drawing.Point(1165, 320);
            this.video_1.Margin = new System.Windows.Forms.Padding(20);
            this.video_1.Name = "video_1";
            this.video_1.Size = new System.Drawing.Size(330, 200);
            this.video_1.TabIndex = 12;
            this.video_1.Text = "Youtube";
            this.video_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.video_1.UseVisualStyleBackColor = false;
            this.video_1.Click += new System.EventHandler(this.video_1_Click);
            // 
            // app_3
            // 
            this.app_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_3.FlatAppearance.BorderSize = 0;
            this.app_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_3.Image = ((System.Drawing.Image)(resources.GetObject("app_3.Image")));
            this.app_3.Location = new System.Drawing.Point(425, 80);
            this.app_3.Margin = new System.Windows.Forms.Padding(20);
            this.app_3.Name = "app_3";
            this.app_3.Size = new System.Drawing.Size(330, 200);
            this.app_3.TabIndex = 5;
            this.app_3.Text = "Disney+";
            this.app_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_3.UseVisualStyleBackColor = false;
            this.app_3.Click += new System.EventHandler(this.app_3_Click);
            // 
            // app_5
            // 
            this.app_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_5.FlatAppearance.BorderSize = 0;
            this.app_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_5.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_5.Image = ((System.Drawing.Image)(resources.GetObject("app_5.Image")));
            this.app_5.Location = new System.Drawing.Point(1165, 80);
            this.app_5.Margin = new System.Windows.Forms.Padding(20);
            this.app_5.Name = "app_5";
            this.app_5.Size = new System.Drawing.Size(330, 200);
            this.app_5.TabIndex = 7;
            this.app_5.Text = "tving";
            this.app_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_5.UseVisualStyleBackColor = false;
            this.app_5.Click += new System.EventHandler(this.app_5_Click);
            // 
            // app_9
            // 
            this.app_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_9.FlatAppearance.BorderSize = 0;
            this.app_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_9.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_9.Image = ((System.Drawing.Image)(resources.GetObject("app_9.Image")));
            this.app_9.Location = new System.Drawing.Point(795, 320);
            this.app_9.Margin = new System.Windows.Forms.Padding(20);
            this.app_9.Name = "app_9";
            this.app_9.Size = new System.Drawing.Size(330, 200);
            this.app_9.TabIndex = 11;
            this.app_9.Text = "Series ON";
            this.app_9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_9.UseVisualStyleBackColor = false;
            this.app_9.Click += new System.EventHandler(this.app_9_Click);
            // 
            // app_6
            // 
            this.app_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_6.FlatAppearance.BorderSize = 0;
            this.app_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_6.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_6.Image = ((System.Drawing.Image)(resources.GetObject("app_6.Image")));
            this.app_6.Location = new System.Drawing.Point(1535, 80);
            this.app_6.Margin = new System.Windows.Forms.Padding(20);
            this.app_6.Name = "app_6";
            this.app_6.Size = new System.Drawing.Size(330, 200);
            this.app_6.TabIndex = 8;
            this.app_6.Text = "watcha";
            this.app_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_6.UseVisualStyleBackColor = false;
            this.app_6.Click += new System.EventHandler(this.app_6_Click);
            // 
            // app_8
            // 
            this.app_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_8.FlatAppearance.BorderSize = 0;
            this.app_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_8.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_8.Image = ((System.Drawing.Image)(resources.GetObject("app_8.Image")));
            this.app_8.Location = new System.Drawing.Point(425, 320);
            this.app_8.Margin = new System.Windows.Forms.Padding(20);
            this.app_8.Name = "app_8";
            this.app_8.Size = new System.Drawing.Size(330, 200);
            this.app_8.TabIndex = 10;
            this.app_8.Text = "Coupang Play";
            this.app_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_8.UseVisualStyleBackColor = false;
            this.app_8.Click += new System.EventHandler(this.app_8_Click);
            // 
            // app_7
            // 
            this.app_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.app_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_7.FlatAppearance.BorderSize = 0;
            this.app_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.app_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.app_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_7.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_7.Image = ((System.Drawing.Image)(resources.GetObject("app_7.Image")));
            this.app_7.Location = new System.Drawing.Point(55, 320);
            this.app_7.Margin = new System.Windows.Forms.Padding(20);
            this.app_7.Name = "app_7";
            this.app_7.Size = new System.Drawing.Size(330, 200);
            this.app_7.TabIndex = 9;
            this.app_7.Text = "wavve";
            this.app_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.app_7.UseVisualStyleBackColor = false;
            this.app_7.Click += new System.EventHandler(this.app_7_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.live_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sc_panel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.app);
            this.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "main";
            this.Text = "goUP TV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.Click += new System.EventHandler(this.app_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            this.live_panel.ResumeLayout(false);
            this.app.ResumeLayout(false);
            this.app.PerformLayout();
            this.sc_panel.ResumeLayout(false);
            this.sc_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button live1;
        private System.Windows.Forms.Button app_2;
        private System.Windows.Forms.Button app_3;
        private System.Windows.Forms.Button app_4;
        private System.Windows.Forms.Button app_5;
        private System.Windows.Forms.Button app_6;
        private System.Windows.Forms.Button app_7;
        private System.Windows.Forms.Button app_9;
        private System.Windows.Forms.Button app_8;
        private System.Windows.Forms.Timer am_open;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button video_1;
        private System.Windows.Forms.Button live2;
        private System.Windows.Forms.Button app_1;
        private System.Windows.Forms.Panel live_panel;
        private System.Windows.Forms.Panel app;
        private System.Windows.Forms.Button video_2;
        private System.Windows.Forms.Label menutitle_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sc_panel;
        private System.Windows.Forms.Button sc_bt;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button spo_1;
        private System.Windows.Forms.Button spo_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer am_close;
    }
}

