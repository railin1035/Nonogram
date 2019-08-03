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
    public partial class Form1 : Form
    {
        level5List lv1list;
        public Form1()
        {
            InitializeComponent();
        }

        private void lv1Btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.lv1list = new level5List();
            lv1list.Show();
            this.lv1list.FormClosed += new FormClosedEventHandler(exit_Click);

        }

        private void exit_Click(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
