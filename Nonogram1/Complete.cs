using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Nonogram1
{
    public partial class Complete : Form
    {
        private int level, gameNum;
        string[] texts = { "하트", "모래시계", "해골", "수리검" };

        Form1 main;
        level5List lv5List;
        Level5Game lv5game;

        public Complete()
        {
            InitializeComponent();
        }

        public Complete(int lv, int num)
        {
            InitializeComponent();
            level = lv;
            gameNum = num;
            string imgName = "completion" + (num-1);
            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap sImg = (Bitmap)rm.GetObject(imgName);

            pictureBox1.Image = sImg;
            label2.Text = texts[num - 1];
        }

        private void goNextBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (level == 5)
            {
                this.lv5game = new Level5Game(gameNum);
                lv5game.Show();
                this.lv5game.FormClosed += new FormClosedEventHandler(exit_Click);
            }
        }

        private void goListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (level == 5)
            {
                this.lv5List = new level5List();
                lv5List.Show();
                this.lv5List.FormClosed += new FormClosedEventHandler(exit_Click);
            }
        }

        private void exit_Click(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MainMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main = new Form1();
            main.Show();
            this.main.FormClosed += new FormClosedEventHandler(exit_Click);
        }
    }
}
