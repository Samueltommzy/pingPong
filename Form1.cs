using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samPingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public Form1()
           
        {
            InitializeComponent();

         
            timer1.Enabled = true;
            //Cursor.Hide;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            racket.Top = playground.Bottom - (playground.Bottom / 20);
            gameOver.Left = (playground.Width / 2) - (gameOver.Width / 2);
            gameOver.Top = (playground.Height / 2) - (gameOver.Height / 2);
            gameOver.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape){
                this.Close();
            }
            if (e.KeyCode == Keys.S)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                points.Text = "0";
                timer1.Enabled = true;
                gameOver.Visible = false;
                playground.BackColor = Color.White;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom &&
                ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 10;
                points.Text = point.ToString();
                Random random = new Random();
                playground.BackColor = Color.DarkViolet;
            }
                if (ball.Left <= playground.Left)
                {
                    speed_left = -speed_left;
                }
                if (ball.Right >= playground.Right)
                {
                    speed_left = -speed_left;
                }
                if (ball.Top <= playground.Top)
                {
                    speed_top = -speed_top;
                }
                if (ball.Bottom >= playground.Bottom)
                {
                    timer1.Enabled = false;
                    gameOver.Visible = true;

                }
            }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameOver_Click(object sender, EventArgs e)
        {

        }

       
    }
}
