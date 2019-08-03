namespace Nonogram1
{
    partial class TitlePan
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv4Btn = new System.Windows.Forms.Button();
            this.lv1Btn = new System.Windows.Forms.Button();
            this.lv2Btn = new System.Windows.Forms.Button();
            this.lv3Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lv4Btn);
            this.panel1.Controls.Add(this.lv1Btn);
            this.panel1.Controls.Add(this.lv2Btn);
            this.panel1.Controls.Add(this.lv3Btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 437);
            this.panel1.TabIndex = 4;
            // 
            // lv4Btn
            // 
            this.lv4Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
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
            this.lv1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lv1Btn.Font = new System.Drawing.Font("210 M고딕OTF 070", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv1Btn.ForeColor = System.Drawing.Color.White;
            this.lv1Btn.Location = new System.Drawing.Point(466, 45);
            this.lv1Btn.Name = "lv1Btn";
            this.lv1Btn.Size = new System.Drawing.Size(237, 62);
            this.lv1Btn.TabIndex = 6;
            this.lv1Btn.Text = "5 X 5";
            this.lv1Btn.UseVisualStyleBackColor = false;
            // 
            // lv2Btn
            // 
            this.lv2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
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
            // TitlePan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TitlePan";
            this.Size = new System.Drawing.Size(784, 437);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lv4Btn;
        private System.Windows.Forms.Button lv1Btn;
        private System.Windows.Forms.Button lv2Btn;
        private System.Windows.Forms.Button lv3Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
