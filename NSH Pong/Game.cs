using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NSH_Pong
{
    class Game
    {
        private Form1 form;
        private Ball ball;
        private Rocket r1;
        private Rocket r2;
        private int HSMP;
        private int score1;
        private int score2;
        public Game(Form1 frm)
        {
            this.form = frm;
            ball = new Ball(form);
            r1 = new Rocket(form);
            r1.FirstLocation(0);
            r2 = new Rocket(form);
            r2.FirstLocation(form.Height - 10);
        }
        public int CheckX1()
        {
            if (ball.GetX() >= r1.GetFirstX() && ball.GetX() <= r1.GetSecondX())
            {
                return 1;
            }
            else if (ball.GetX() < r1.GetFirstX() || ball.GetX() > r1.GetSecondX())
            {
                return 2;
            }
            return 5;
        }
        public int CheckX2()
        {
            if (ball.GetX() >= r2.GetFirstX() && ball.GetX() <= r2.GetSecondX())
            {
                return 3;
            }
            else if (ball.GetX() < r2.GetFirstX() || ball.GetX() > r2.GetSecondX())
            {
                return 4;
            }
            return 5;
        }
        public Status Checking()
        {
            if (ball.GetY() <= 10 && CheckX1() == 1)
            {
                return Status.upperRocketCatched;
            }
            else if (ball.GetY() <= 10 && CheckX1() == 2)
            {
                return Status.upperRocketFailed;
            }
            else if (ball.GetY() >= 590 && CheckX2() == 3)
            {
                return Status.lowerRocketCatched;
            }
            else if (ball.GetY() >= 590 && CheckX2() == 4)
            {
                return Status.lowerRocketFailed;
            }
            return Status.nothing;
        }
        public int GetScore1()
        {
            return score1;
        }
        public int GetScore2()
        {
            return score2;
        }
        public void Run()
        {
            ball.MoveBall();
            Status res = Checking();
            switch (res)
            {
                case Status.nothing:
                    break;
                case Status.lowerRocketCatched:
                    ball.SetDirection(Direction.up);
                    break;
                case Status.lowerRocketFailed:
                    ball.TeleportBall2(ball.GetX());
                    ball.SetDirection(Direction.up);
                    if (form.GetExtreme() == true)
                    {
                        MessageBox.Show("Upper rocket won!");
                        form.Close();
                    }
                    score1++;
                    break;
                case Status.upperRocketCatched:
                    ball.SetDirection(Direction.down);
                    break;
                case Status.upperRocketFailed:
                    ball.SetDirection(Direction.down);
                    if (form.GetExtreme() == true)
                    {
                        MessageBox.Show("Lower rocket won!");
                        form.Close();
                    }
                    score2++;
                    break;
            }
        }
        public void GameClose()
        {
            if (score1 > score2)
            {
                HSMP = score1;
                SetHSMP();
                MessageBox.Show("Upper rocket won!", "Score: " + score1 + "\nHighscore: " + HSMP);
                form.Close();
            }
            else if (score1 < score2)
            {
                HSMP = score2;
                SetHSMP();
                MessageBox.Show("Lower rocket won!", "Score: " + score2 + "\nHighscore: " + HSMP);
                form.Close();
            }
            else
            {
                HSMP = score1;
                SetHSMP();
                MessageBox.Show("Tie!", "Score: " + score1 + "\nHighscore: " + HSMP);
                form.Close();
            }
        }
        public void Rocket1Direction(Direction d)
        {
            r1.moveRocket(d);
        }
        public void Rocket2Direction(Direction d)
        {
            r2.moveRocket(d);
        }
        
        public void SetHSMP()
        {
            StreamReader sr = new StreamReader("score.txt");
            string all = sr.ReadToEnd();
            string[] lines = all.Trim('\r').Trim('\n').Split('\n');
            int HSMPtemp = Convert.ToInt32(lines[0]);
            sr.Close();
            if (HSMP > HSMPtemp)
            {
                StreamWriter sw = new StreamWriter("score.txt", false);
                sw.WriteLine(HSMP);
                sw.Close();
            }
            else
                HSMP = HSMPtemp;
        }
    }
    public enum Direction
    {
        up,
        down,
        right,
        left,
    }
    public enum Status
    {
        nothing,
        lowerRocketFailed,
        upperRocketFailed,
        upperRocketCatched,
        lowerRocketCatched
    }

}
