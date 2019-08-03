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
    public partial class level5List : Form
    {
        Form1 main;
        Level5Game gameStart;
        public level5List()
        {
            InitializeComponent();
        }

        private void MainMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main = new Form1();
            main.Show();
            this.main.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void exit_Click(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //게임 리스트 클릭시 해당 게임으로 이동
        private void game1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gameStart = new Level5Game(0);
            gameStart.Show();
            this.gameStart.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void game2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gameStart = new Level5Game(1);
            gameStart.Show();
            this.gameStart.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void game3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gameStart = new Level5Game(2);
            gameStart.Show();
            this.gameStart.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void game4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gameStart = new Level5Game(3);
            gameStart.Show();
            this.gameStart.FormClosed += new FormClosedEventHandler(exit_Click);
        }
    }
}
