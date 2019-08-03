namespace Nonogram1
{
    partial class GameOver
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
            this.bgPan = new System.Windows.Forms.Panel();
            this.goReBtn = new System.Windows.Forms.Button();
            this.goListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.bgPan.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            this.MainMToolStripMenuItem.Click += new System.EventHandler(this.MainMToolStripMenuItem_Click);
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
            // bgPan
            // 
            this.bgPan.BackColor = System.Drawing.Color.LavenderBlush;
            this.bgPan.Controls.Add(this.goReBtn);
            this.bgPan.Controls.Add(this.goListBtn);
            this.bgPan.Controls.Add(this.pictureBox1);
            this.bgPan.Controls.Add(this.label1);
            this.bgPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPan.Location = new System.Drawing.Point(0, 24);
            this.bgPan.Name = "bgPan";
            this.bgPan.Size = new System.Drawing.Size(784, 437);
            this.bgPan.TabIndex = 2;
            // 
            // goReBtn
            // 
            this.goReBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.goReBtn.FlatAppearance.BorderSize = 0;
            this.goReBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goReBtn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goReBtn.ForeColor = System.Drawing.Color.White;
            this.goReBtn.Location = new System.Drawing.Point(418, 351);
            this.goReBtn.Name = "goReBtn";
            this.goReBtn.Size = new System.Drawing.Size(138, 44);
            this.goReBtn.TabIndex = 3;
            this.goReBtn.Text = "R E T R Y";
            this.goReBtn.UseVisualStyleBackColor = false;
            this.goReBtn.Click += new System.EventHandler(this.goReBtn_Click);
            // 
            // goListBtn
            // 
            this.goListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.goListBtn.FlatAppearance.BorderSize = 0;
            this.goListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goListBtn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goListBtn.ForeColor = System.Drawing.Color.White;
            this.goListBtn.Location = new System.Drawing.Point(228, 351);
            this.goListBtn.Name = "goListBtn";
            this.goListBtn.Size = new System.Drawing.Size(138, 44);
            this.goListBtn.TabIndex = 2;
            this.goListBtn.Text = "L I S T";
            this.goListBtn.UseVisualStyleBackColor = false;
            this.goListBtn.Click += new System.EventHandler(this.goListBtn_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "F A I L";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nonogram1.Properties.Resources.LogoLarge;
            this.pictureBox1.Location = new System.Drawing.Point(257, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bgPan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(230, 90);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "다함께 노노그램!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bgPan.ResumeLayout(false);
            this.bgPan.PerformLayout();
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
        private System.Windows.Forms.Panel bgPan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goListBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button goReBtn;
    }
}