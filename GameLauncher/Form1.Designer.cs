namespace GameLauncher
{
    partial class Form1
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
            System.Windows.Forms.Button fps;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popular = new System.Windows.Forms.Button();
            this.helpbutton = new System.Windows.Forms.Button();
            this.online = new System.Windows.Forms.Button();
            this.mobile = new System.Windows.Forms.Button();
            this.Chromee = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.Button();
            this.sports = new System.Windows.Forms.Button();
            this.casual = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.Button();
            this.messenger = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.internet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            fps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fps
            // 
            fps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fps.BackgroundImage")));
            fps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            fps.Cursor = System.Windows.Forms.Cursors.Hand;
            fps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            fps.Location = new System.Drawing.Point(536, 92);
            fps.Name = "fps";
            fps.Size = new System.Drawing.Size(149, 120);
            fps.TabIndex = 4;
            fps.UseVisualStyleBackColor = true;
            fps.Click += new System.EventHandler(this.FPS_Click);
            // 
            // popular
            // 
            this.popular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popular.BackgroundImage")));
            this.popular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.popular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.popular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.popular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.popular.Location = new System.Drawing.Point(8, 92);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(325, 120);
            this.popular.TabIndex = 0;
            this.popular.UseVisualStyleBackColor = true;
            this.popular.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.helpbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpbutton.Location = new System.Drawing.Point(360, 344);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(125, 63);
            this.helpbutton.TabIndex = 1;
            this.helpbutton.Text = "내 컴퓨터";
            this.helpbutton.UseVisualStyleBackColor = false;
            this.helpbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // online
            // 
            this.online.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("online.BackgroundImage")));
            this.online.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.online.Cursor = System.Windows.Forms.Cursors.Hand;
            this.online.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.online.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.online.Location = new System.Drawing.Point(360, 92);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(149, 120);
            this.online.TabIndex = 3;
            this.online.UseVisualStyleBackColor = true;
            this.online.Click += new System.EventHandler(this.Online_Click);
            // 
            // mobile
            // 
            this.mobile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mobile.BackgroundImage")));
            this.mobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mobile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mobile.Location = new System.Drawing.Point(712, 92);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(149, 120);
            this.mobile.TabIndex = 5;
            this.mobile.UseVisualStyleBackColor = true;
            this.mobile.Click += new System.EventHandler(this.mobile_Click);
            // 
            // Chromee
            // 
            this.Chromee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chromee.BackgroundImage")));
            this.Chromee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chromee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chromee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Chromee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Chromee.Location = new System.Drawing.Point(267, 31);
            this.Chromee.Name = "Chromee";
            this.Chromee.Size = new System.Drawing.Size(242, 55);
            this.Chromee.TabIndex = 6;
            this.Chromee.UseVisualStyleBackColor = true;
            this.Chromee.Click += new System.EventHandler(this.internet_Click);
            // 
            // cd
            // 
            this.cd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cd.BackgroundImage")));
            this.cd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cd.Location = new System.Drawing.Point(8, 218);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(149, 120);
            this.cd.TabIndex = 7;
            this.cd.UseVisualStyleBackColor = true;
            this.cd.Click += new System.EventHandler(this.cd_Click);
            // 
            // sports
            // 
            this.sports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sports.BackgroundImage")));
            this.sports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sports.Location = new System.Drawing.Point(184, 218);
            this.sports.Name = "sports";
            this.sports.Size = new System.Drawing.Size(149, 120);
            this.sports.TabIndex = 8;
            this.sports.UseVisualStyleBackColor = true;
            this.sports.Click += new System.EventHandler(this.sports_Click);
            // 
            // casual
            // 
            this.casual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("casual.BackgroundImage")));
            this.casual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.casual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.casual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.casual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.casual.Location = new System.Drawing.Point(360, 218);
            this.casual.Name = "casual";
            this.casual.Size = new System.Drawing.Size(149, 120);
            this.casual.TabIndex = 9;
            this.casual.UseVisualStyleBackColor = true;
            this.casual.Click += new System.EventHandler(this.casual_Click);
            // 
            // board
            // 
            this.board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("board.BackgroundImage")));
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.board.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.board.Location = new System.Drawing.Point(536, 218);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(149, 120);
            this.board.TabIndex = 10;
            this.board.UseVisualStyleBackColor = true;
            this.board.Click += new System.EventHandler(this.board_Click);
            // 
            // messenger
            // 
            this.messenger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("messenger.BackgroundImage")));
            this.messenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messenger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.messenger.Location = new System.Drawing.Point(712, 218);
            this.messenger.Name = "messenger";
            this.messenger.Size = new System.Drawing.Size(149, 120);
            this.messenger.TabIndex = 11;
            this.messenger.UseVisualStyleBackColor = true;
            this.messenger.Click += new System.EventHandler(this.messenger_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings.Location = new System.Drawing.Point(486, 344);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(125, 63);
            this.settings.TabIndex = 14;
            this.settings.Text = "마우스 설정";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.LightSteelBlue;
            this.version.Cursor = System.Windows.Forms.Cursors.Hand;
            this.version.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.version.Location = new System.Drawing.Point(738, 344);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(125, 63);
            this.version.TabIndex = 15;
            this.version.Text = "모니터 비율 전환";
            this.version.UseVisualStyleBackColor = false;
            this.version.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(536, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 55);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // internet
            // 
            this.internet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("internet.BackgroundImage")));
            this.internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.internet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.internet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.internet.Location = new System.Drawing.Point(8, 31);
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(242, 55);
            this.internet.TabIndex = 17;
            this.internet.UseVisualStyleBackColor = true;
            this.internet.Click += new System.EventHandler(this.internet_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(612, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 63);
            this.button1.TabIndex = 18;
            this.button1.Text = "키보드 설정";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 136);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem1.Text = "윈도우 마우스 설정";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem2.Text = "로지텍 마우스 설정";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem3.Text = "내 컴퓨터";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem4.Text = "런처 위치 재배치 (재실행)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem5.Text = "Pepsi is OK?";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.internet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.messenger);
            this.Controls.Add(this.board);
            this.Controls.Add(this.casual);
            this.Controls.Add(this.sports);
            this.Controls.Add(this.cd);
            this.Controls.Add(this.Chromee);
            this.Controls.Add(this.mobile);
            this.Controls.Add(fps);
            this.Controls.Add(this.online);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.popular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noble Launcher";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button popular;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.Button online;
        private System.Windows.Forms.Button mobile;
        private System.Windows.Forms.Button Chromee;
        private System.Windows.Forms.Button cd;
        private System.Windows.Forms.Button sports;
        private System.Windows.Forms.Button casual;
        private System.Windows.Forms.Button board;
        private System.Windows.Forms.Button messenger;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button internet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

