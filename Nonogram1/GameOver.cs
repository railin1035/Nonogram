using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram1
{
    public partial class GameOver : Form
    {
        private int level, gameNum;

        Form1 main;
        level5List lv5List;
        Level5Game lv5game;

        public GameOver()
        {
            InitializeComponent();
        }
        public GameOver(int lv, int num)
        {
            InitializeComponent();
            level = lv;
            gameNum = num;
        }

        private void goReBtn_Click(object sender, EventArgs e)
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
