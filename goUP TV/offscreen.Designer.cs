namespace goUP_TV
{
    partial class offscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.d_bt = new System.Windows.Forms.Button();
            this.u_bt = new System.Windows.Forms.Button();
            this.zzz_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close_timer = new System.Windows.Forms.Timer(this.components);
            this.menu_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "켜기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 300F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(25, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1190, 532);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:00";
            // 
            // d_bt
            // 
            this.d_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.d_bt.FlatAppearance.BorderSize = 0;
            this.d_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_bt.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.d_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.d_bt.Location = new System.Drawing.Point(300, 0);
            this.d_bt.Name = "d_bt";
            this.d_bt.Size = new System.Drawing.Size(45, 45);
            this.d_bt.TabIndex = 3;
            this.d_bt.Text = "-";
            this.d_bt.UseVisualStyleBackColor = false;
            this.d_bt.Click += new System.EventHandler(this.d_bt_Click);
            // 
            // u_bt
            // 
            this.u_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.u_bt.FlatAppearance.BorderSize = 0;
            this.u_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.u_bt.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.u_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.u_bt.Location = new System.Drawing.Point(351, 0);
            this.u_bt.Name = "u_bt";
            this.u_bt.Size = new System.Drawing.Size(45, 45);
            this.u_bt.TabIndex = 4;
            this.u_bt.Text = "+";
            this.u_bt.UseVisualStyleBackColor = false;
            this.u_bt.Click += new System.EventHandler(this.u_bt_Click);
            // 
            // zzz_bt
            // 
            this.zzz_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.zzz_bt.FlatAppearance.BorderSize = 0;
            this.zzz_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zzz_bt.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zzz_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.zzz_bt.Location = new System.Drawing.Point(150, 0);
            this.zzz_bt.Name = "zzz_bt";
            this.zzz_bt.Size = new System.Drawing.Size(144, 45);
            this.zzz_bt.TabIndex = 5;
            this.zzz_bt.Text = "취침모드";
            this.zzz_bt.UseVisualStyleBackColor = false;
            this.zzz_bt.Click += new System.EventHandler(this.zzz_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 50F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(640, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 89);
            this.label1.TabIndex = 6;
            this.label1.Text = "로드중...";
            this.label1.Visible = false;
            // 
            // close_timer
            // 
            this.close_timer.Interval = 10;
            this.close_timer.Tick += new System.EventHandler(this.close_timer_Tick);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.button1);
            this.menu_panel.Controls.Add(this.d_bt);
            this.menu_panel.Controls.Add(this.zzz_bt);
            this.menu_panel.Controls.Add(this.u_bt);
            this.menu_panel.Location = new System.Drawing.Point(30, 30);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(396, 45);
            this.menu_panel.TabIndex = 7;
            // 
            // offscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "offscreen";
            this.Text = "offscreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.offscreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.offscreen_KeyDown);
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button d_bt;
        private System.Windows.Forms.Button u_bt;
        private System.Windows.Forms.Button zzz_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer close_timer;
        private System.Windows.Forms.Panel menu_panel;
    }
}