using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NSH_Pong
{
    class Ball
    {
        private PictureBox ballPic;
        private Direction ballDirection;
        private Form form;
        private int size = 20;
        private Line line;
        public Ball(Form frm)
        {
            this.form = frm;
            ballPic = new PictureBox();
            line = new Line();
            FirstLocation();
            form.Controls.Add(ballPic);
            ballDirection = Direction.down;
        }
        public void SetDirection(Direction d)
        {
            int w = form.Width;
            int h = form.Height;
            this.ballDirection = d;
            Random r = new Random();
            int temp = r.Next(0, w);
            if (temp > 220 && temp < 280)
                temp = 0;
            Point next = new Point();
            if (ballDirection == Direction.down)
                next = new Point(temp, h);
            else if (ballDirection == Direction.up)
                next = new Point(temp, 0);
            line.SetLine(ballPic.Location, next);
        }
        public void TeleportBall2(int n)
        {
            ballPic.Location = new Point(n,590);
        }
        public void FirstLocation()
        {
            int w = form.Width;
            int h = form.Height;
            ballPic.Location = new Point(250,300);
            ballPic.Size = new Size(w / size, h / size);
            ballPic.BackgroundImage = Properties.Resources.Ball;
            ballPic.BackgroundImageLayout = ImageLayout.Zoom;
            Random r = new Random();
            int temp = r.Next(0, w);
            if (temp > 220 && temp < 280)
                temp = 0;
            Point next = new Point();
            if (ballDirection == Direction.down)
                next = new Point(temp,h);
            else if (ballDirection == Direction.up)
                next = new Point(temp, 0);
            line.SetLine(ballPic.Location, next);
        }
        public void MoveBall()
        {
            if (ballDirection == Direction.down)
                ballPic.Location = new Point(ballPic.Location.X + line.GetM(), line.GetY(ballPic.Location.X + line.GetM()));
            else if (ballDirection == Direction.up)
                ballPic.Location = new Point(ballPic.Location.X - line.GetM(), line.GetY(ballPic.Location.X - line.GetM()));
        }
        public int GetX()
        {
            return ballPic.Location.X;
        }
        public int GetY()
        {
            return ballPic.Location.Y;
        }
    }
    class Line
    {
        private double m;
        private double h;
        public Line()
        {

        }
        public void SetLine(Point p1, Point p2)
        {
            m = (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
            h = p1.Y - (double)(m * p1.X);
        }
        public int GetY(int x)
        {
            return (int)(m * x + h);
        }
        public int GetM()
        {
            if (m > 0)
                return 5;
            else
                return -5;
        }
        
    }
}
