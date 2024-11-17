using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NSH_Pong
{
    public partial class Form1 : Form
    {
        private bool Extreme = false;
        public bool GetExtreme()
        {
            if (Extreme == true)
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        Game game;
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("score.txt");
            string all = sr.ReadToEnd();
            string[] lines = all.Trim('\r').Trim('\n').Split('\n');
            labelHS_MP.Text += lines[0];
            sr.Close();
        }

        private void buttonStartMPEM_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelName.Visible = false;
            game = new Game(this);
            timer1.Enabled = true;
            timer1.Start();
            Extreme = true;
        }

        private void buttonStartMPSM_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelName.Visible = false;
            game = new Game(this);
            timer1.Enabled = true;
            timer1.Start();
            labelUpScore.Visible = true;
            labelLowScore.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Run();
            labelLowScore.Text = Convert.ToString(game.GetScore2());
            labelUpScore.Text = Convert.ToString(game.GetScore1());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                game.Rocket1Direction(Direction.left);
            }
            else if (e.KeyData == Keys.Right)
            {
                game.Rocket1Direction(Direction.right);
            }
            if (e.KeyData == Keys.A)
            {
                game.Rocket2Direction(Direction.left);
            }
            else if (e.KeyData == Keys.D)
            {
                game.Rocket2Direction(Direction.right);
            }
            else if (e.KeyData == Keys.Escape && Extreme == false)
            {
                timer1.Stop();
                game.GameClose();
            }
        }
    }
}
