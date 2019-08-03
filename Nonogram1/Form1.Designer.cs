namespace Nonogram1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docPan = new System.Windows.Forms.Panel();
            this.titlePan = new System.Windows.Forms.Panel();
            this.lv4Btn = new System.Windows.Forms.Button();
            this.lv1Btn = new System.Windows.Forms.Button();
            this.lv2Btn = new System.Windows.Forms.Button();
            this.lv3Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.docPan.SuspendLayout();
            this.titlePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMToolStripMenuItem,
            this.SaveSToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitXToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // MainMToolStripMenuItem
            // 
            this.MainMToolStripMenuItem.Name = "MainMToolStripMenuItem";
            this.MainMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MainMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MainMToolStripMenuItem.Text = "메인(&M)";
            // 
            // SaveSToolStripMenuItem
            // 
            this.SaveSToolStripMenuItem.Enabled = false;
            this.SaveSToolStripMenuItem.Name = "SaveSToolStripMenuItem";
            this.SaveSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveSToolStripMenuItem.Text = "저장(&S)";
            // 
            // OpenOToolStripMenuItem
            // 
            this.OpenOToolStripMenuItem.Enabled = false;
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            this.OpenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenOToolStripMenuItem.Text = "열기(&O)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitXToolStripMenuItem.Text = "종료(&X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(23, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContHToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ContHToolStripMenuItem
            // 
            this.ContHToolStripMenuItem.Name = "ContHToolStripMenuItem";
            this.ContHToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ContHToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ContHToolStripMenuItem.Text = "조작방법(&H)";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.InfoToolStripMenuItem.Text = "프로그램 정보";
            // 
            // docPan
            // 
            this.docPan.Controls.Add(this.titlePan);
            this.docPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docPan.Location = new System.Drawing.Point(0, 24);
            this.docPan.Name = "docPan";
            this.docPan.Size = new System.Drawing.Size(784, 437);
            this.docPan.TabIndex = 2;
            // 
            // titlePan
            // 
            this.titlePan.BackColor = System.Drawing.Color.LavenderBlush;
            this.titlePan.Controls.Add(this.lv4Btn);
            this.titlePan.Controls.Add(this.lv1Btn);
            this.titlePan.Controls.Add(this.lv2Btn);
            this.titlePan.Controls.Add(this.lv3Btn);
            this.titlePan.Controls.Add(this.pictureBox1);
            this.titlePan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePan.Location = new System.Drawing.Point(0, 0);
            this.titlePan.Name = "titlePan";
            this.titlePan.Size = new System.Drawing.Size(784, 437);
            this.titlePan.TabIndex = 3;
            // 
            // lv4Btn
            // 
            this.lv4Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.lv4Btn.FlatAppearance.BorderSize = 0;
            this.lv4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lv4Btn.Font = new System.Drawing.Font("210 M고딕OTF 070", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv4Btn.ForeColor = System.Drawing.Color.White;
            this.lv4Btn.Location = new System.Drawing.Point(466, 321);
            this.lv4Btn.Name = "lv4Btn";
            this.lv4Btn.Size = new System.Drawing.Size(237, 62);
            this.lv4Btn.TabIndex = 9;
            this.lv4Btn.Text = "20 X 20";
            this.lv4Btn.UseVisualStyleBackColor = false;
            // 
            // lv1Btn
            // 
            this.lv1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.lv1Btn.FlatAppearance.BorderSize = 0;
            this.lv1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lv1Btn.Font = new System.Drawing.Font("210 M고딕OTF 070", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv1Btn.ForeColor = System.Drawing.Color.White;
            this.lv1Btn.Location = new System.Drawing.Point(466, 45);
            this.lv1Btn.Name = "lv1Btn";
            this.lv1Btn.Size = new System.Drawing.Size(237, 62);
            this.lv1Btn.TabIndex = 6;
            this.lv1Btn.Text = "5 X 5";
            this.lv1Btn.UseVisualStyleBackColor = false;
            this.lv1Btn.Click += new System.EventHandler(this.lv1Btn_Click);
            // 
            // lv2Btn
            // 
            this.lv2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.lv2Btn.FlatAppearance.BorderSize = 0;
            this.lv2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lv2Btn.Font = new System.Drawing.Font("210 M고딕OTF 070", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv2Btn.ForeColor = System.Drawing.Color.White;
            this.lv2Btn.Location = new System.Drawing.Point(466, 137);
            this.lv2Btn.Name = "lv2Btn";
            this.lv2Btn.Size = new System.Drawing.Size(237, 62);
            this.lv2Btn.TabIndex = 7;
            this.lv2Btn.Text = "10 X 10";
            this.lv2Btn.UseVisualStyleBackColor = false;
            // 
            // lv3Btn
            // 
            this.lv3Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv3Btn.FlatAppearance.BorderSize = 0;
            this.lv3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lv3Btn.Font = new System.Drawing.Font("210 M고딕OTF 070", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv3Btn.ForeColor = System.Drawing.Color.White;
            this.lv3Btn.Location = new System.Drawing.Point(466, 229);
            this.lv3Btn.Name = "lv3Btn";
            this.lv3Btn.Size = new System.Drawing.Size(237, 62);
            this.lv3Btn.TabIndex = 8;
            this.lv3Btn.Text = "15 X 15";
            this.lv3Btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nonogram1.Properties.Resources.nonogramLogo8_03;
            this.pictureBox1.Location = new System.Drawing.Point(100, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.docPan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(230, 90);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "다함께 노노그램!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.docPan.ResumeLayout(false);
            this.titlePan.ResumeLayout(false);
            this.titlePan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.Panel docPan;
        private System.Windows.Forms.Panel titlePan;
        private System.Windows.Forms.Button lv4Btn;
        private System.Windows.Forms.Button lv1Btn;
        private System.Windows.Forms.Button lv2Btn;
        private System.Windows.Forms.Button lv3Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

