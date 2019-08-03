using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Nonogram1
{
    class Game5X5
    {
        public enum CheckedBtn { BLANK = 3, CHECK = 6, NOPE = 9, WRONG = 12 }
        private CheckedBtn[] userAnswer = new CheckedBtn[25];
        private int[] CorrectData = new int[25];
        Assembly _assembly = Assembly.GetExecutingAssembly();
        StreamReader _answerReader;
        StreamReader _hintReader;

        //새 게임
        public void createGame(int index)
        {
            getCorrectData(index);
            for (int i = 0; i < 25; i++)
            {
                userAnswer[i] = CheckedBtn.BLANK;
            }
        }

        //클릭된 버튼 답 체크
        public CheckedBtn isValid(String btn, CheckedBtn cb)
        {
            int index = Convert.ToInt32(btn.Substring(6));

            if (CorrectData[index] == (int)cb) { userAnswer[index] = cb; }
            else { userAnswer[index] = CheckedBtn.WRONG; }

            return userAnswer[index];
        }

        //전체 정답 체크
        public bool isSuccess()
        {
            for(int i=0; i<25; i++)
            {
                if(CorrectData[i] == 6)
                {
                    if(userAnswer[i] == CheckedBtn.BLANK)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //버튼 컬러
        public Color ToColor(CheckedBtn ch)
        {
            switch (ch)
            {
                case CheckedBtn.NOPE:
                    return Color.DimGray;
                case CheckedBtn.CHECK:
                    return Color.Crimson;
                default:
                    return Color.White;
            }
        }

        //정답 파일에서 정답 추출
        private void getCorrectData(int index)
        {
            _answerReader = new StreamReader(_assembly.GetManifestResourceStream("Nonogram1.Resources.correctAnswer.txt"));
            string data = _answerReader.ReadToEnd();
            string[] lines = data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if(lines.Length > 0)
            {
                string line = lines[index];
                Console.WriteLine(line);
                for (int i = 0; i < 25; i++)
                {
                    CorrectData[i] = Convert.ToInt32(line[i].ToString());
                }
            }
        }


        //힌트 파일에서 텍스트 추출 후 리턴
        public String setHint(int g, int index) //g = game번호 , index = 레이블 번호
        {
            _hintReader = new StreamReader(_assembly.GetManifestResourceStream("Nonogram1.Resources.hint2.txt"));
            string data = _hintReader.ReadToEnd();
            string[] lines = data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            String[] hintLine = lines[g].Split(new String[] { "," }, StringSplitOptions.None);
            String hint = hintLine[index].Replace("e", "\r\n");

            return hint;
        }
    }
    
}
