namespace goUP_TV
{
    partial class smartbar
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
            this.time_timer = new System.Windows.Forms.Timer(this.components);
            this.hide_bt = new System.Windows.Forms.Button();
            this.show_bt = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Button();
            this.keybord_bt = new System.Windows.Forms.Button();
            this.home_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // time_timer
            // 
            this.time_timer.Enabled = true;
            this.time_timer.Interval = 1000;
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // hide_bt
            // 
            this.hide_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hide_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_bt.FlatAppearance.BorderSize = 0;
            this.hide_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_bt.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hide_bt.Location = new System.Drawing.Point(219, 14);
            this.hide_bt.Name = "hide_bt";
            this.hide_bt.Size = new System.Drawing.Size(60, 60);
            this.hide_bt.TabIndex = 4;
            this.hide_bt.Text = "↑";
            this.hide_bt.UseVisualStyleBackColor = false;
            this.hide_bt.Click += new System.EventHandler(this.hide_bt_Click);
            // 
            // show_bt
            // 
            this.show_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.show_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_bt.FlatAppearance.BorderSize = 0;
            this.show_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_bt.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.show_bt.Location = new System.Drawing.Point(0, 80);
            this.show_bt.Name = "show_bt";
            this.show_bt.Size = new System.Drawing.Size(425, 10);
            this.show_bt.TabIndex = 7;
            this.show_bt.UseVisualStyleBackColor = false;
            this.show_bt.Click += new System.EventHandler(this.show_bt_Click);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.time.FlatAppearance.BorderSize = 0;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("맑은 고딕", 28F);
            this.time.Location = new System.Drawing.Point(13, 14);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 60);
            this.time.TabIndex = 8;
            this.time.Text = "LODING...";
            this.time.UseVisualStyleBackColor = false;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // keybord_bt
            // 
            this.keybord_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.keybord_bt.BackgroundImage = global::goUP_TV.Properties.Resources.key;
            this.keybord_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keybord_bt.FlatAppearance.BorderSize = 0;
            this.keybord_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keybord_bt.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.keybord_bt.Location = new System.Drawing.Point(285, 14);
            this.keybord_bt.Name = "keybord_bt";
            this.keybord_bt.Size = new System.Drawing.Size(60, 60);
            this.keybord_bt.TabIndex = 9;
            this.keybord_bt.UseVisualStyleBackColor = false;
            this.keybord_bt.Click += new System.EventHandler(this.keybord_bt_Click);
            // 
            // home_bt
            // 
            this.home_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.home_bt.BackgroundImage = global::goUP_TV.Properties.Resources.home;
            this.home_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home_bt.FlatAppearance.BorderSize = 0;
            this.home_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_bt.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_bt.Location = new System.Drawing.Point(351, 14);
            this.home_bt.Name = "home_bt";
            this.home_bt.Size = new System.Drawing.Size(60, 60);
            this.home_bt.TabIndex = 6;
            this.home_bt.UseVisualStyleBackColor = false;
            this.home_bt.Visible = false;
            this.home_bt.Click += new System.EventHandler(this.nowapp_bt_Click);
            // 
            // smartbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(426, 90);
            this.Controls.Add(this.keybord_bt);
            this.Controls.Add(this.show_bt);
            this.Controls.Add(this.home_bt);
            this.Controls.Add(this.hide_bt);
            this.Controls.Add(this.time);
            this.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "smartbar";
            this.Text = "close";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.close_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.smartbar_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer time_timer;
        private System.Windows.Forms.Button hide_bt;
        private System.Windows.Forms.Button home_bt;
        private System.Windows.Forms.Button show_bt;
        private System.Windows.Forms.Button time;
        private System.Windows.Forms.Button keybord_bt;
    }
}