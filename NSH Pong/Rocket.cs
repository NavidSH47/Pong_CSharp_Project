using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NSH_Pong
{
    class Rocket
    {
        private PictureBox rocketPic;
        private Form form;
        public Rocket(Form frm)
        {
            this.form = frm;
            this.rocketPic = new PictureBox();
        }
        public void FirstLocation(int y)
        {
            int w = form.Width;
            int h = form.Height;
            rocketPic.Location = new Point(w / 2, y);
            rocketPic.Size = new Size(100,10);
            rocketPic.BackgroundImage = Properties.Resources.Rocket;
            rocketPic.BackgroundImageLayout = ImageLayout.Zoom;
            form.Controls.Add(rocketPic);
        }
        public void moveRocket(Direction d)
        {
            if (d == Direction.left && rocketPic.Location.X >= 10)
            {
                rocketPic.Location = new Point(rocketPic.Location.X - 15, rocketPic.Location.Y);
            }
            else if (d == Direction.right && rocketPic.Location.X <= form.Width - 90)
            {
                rocketPic.Location = new Point(rocketPic.Location.X + 15, rocketPic.Location.Y);
            }
        }
        public int GetFirstX()
        {
            return rocketPic.Location.X;
        }
        public int GetSecondX()
        {
            return rocketPic.Location.X + 100;
        }
    }
}
