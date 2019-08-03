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
    public partial class Level5Game : Form
    {
        Game5X5 game = new Game5X5();
        Form1 main;
        level5List lv1list;
        GameOver over;
        Complete comp;
        private int gameLife, gameNum;
        private Game5X5.CheckedBtn answer = Game5X5.CheckedBtn.CHECK;
        private Game5X5.CheckedBtn isCorrect;

        public Level5Game()
        {
            InitializeComponent();
        }

        public Level5Game(int num)
        {
            InitializeComponent();
            gameLife = 6;
            gameNum = num;
        }

        //화면이 로드되면 새 게임을 시작한다.
        private void Level5Game_Load(object sender, EventArgs e)
        {
            game.createGame(gameNum);
            SetHint(gameNum);
        }

        //레이블에 힌트 텍스트 세팅
        public void SetHint(int n)
        {
            for(int i = 0; i < 10; i++)
            {
                String hintName = "hint" + i;
                String hintValue = game.setHint(n, i);
                Control[] ctrls = this.Controls.Find(hintName, true);
                if (ctrls.Length > 0)
                {
                    Label hintText = (Label)ctrls[0];
                    hintText.Text = hintValue;
                }
            }
            
        }

        private void exit_Click(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void MainMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main = new Form1();
            main.Show();
            this.main.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // 게임판 버튼 클릭시 정답 체크
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            isCorrect = game.isValid(clickedBtn.Name, answer);

            switch (isCorrect)
            {
                case Game5X5.CheckedBtn.NOPE:
                    clickedBtn.BackColor = game.ToColor(isCorrect);
                    if (game.isSuccess())
                    {
                        this.Visible = false;
                        comp = new Complete(5, (gameNum+1));
                        comp.Show();
                        this.comp.FormClosed += new FormClosedEventHandler(exit_Click);
                    }
                    break;
                case Game5X5.CheckedBtn.CHECK:
                    clickedBtn.BackColor = game.ToColor(isCorrect);
                    if (game.isSuccess())
                    {
                        this.Visible = false;
                        comp = new Complete(5, (gameNum + 1));
                        comp.Show();
                        this.comp.FormClosed += new FormClosedEventHandler(exit_Click);
                    }
                    break;
                case Game5X5.CheckedBtn.WRONG:
                    gameLife--;
                    if (gameLife == 1)
                    {
                        this.Visible = false;
                        over = new GameOver(5,gameNum);
                        over.Show();
                        this.over.FormClosed += new FormClosedEventHandler(exit_Click);
                    }
                    else
                    {
                        String lifeName = "life" + gameLife;
                        Control[] ctrls = this.Controls.Find(lifeName, true);
                        if (ctrls.Length > 0)
                        {
                            PictureBox life = (PictureBox)ctrls[0];
                            life.Visible = false;
                        }
                        if(answer == Game5X5.CheckedBtn.CHECK)
                        {
                            clickedBtn.BackColor = game.ToColor(Game5X5.CheckedBtn.NOPE);
                        }
                        else
                        {
                            clickedBtn.BackColor = game.ToColor(Game5X5.CheckedBtn.CHECK);
                        }
                        
                    }
                    break;
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.lv1list = new level5List();
            lv1list.Show();
            this.lv1list.FormClosed += new FormClosedEventHandler(exit_Click);
        }

        private void SaveSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //정답용 빈칸용 버튼 토글
        private void chBtn_Click(object sender, EventArgs e)
        {
            Button clickBtn = (Button)sender;
            if (clickBtn.Name.Equals("chBtn"))
            {
                chBtn.BackColor = Color.FromArgb(237, 89, 89);
                noBtn.BackColor = Color.FromArgb(244, 154, 154);
                answer = Game5X5.CheckedBtn.CHECK;
            }
            else if (clickBtn.Name.Equals("noBtn"))
            {
                chBtn.BackColor = Color.FromArgb(244, 154, 154);
                noBtn.BackColor = Color.FromArgb(237, 89, 89);
                answer = Game5X5.CheckedBtn.NOPE;
            }

        }

    }
}
