using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    
    public partial class Form1 : Form
    {
        private int gameSpeed = 5;
        private int score;
        private int x;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            PoliceCar(gameSpeed);
            Coins(gameSpeed);
            CoinsCollection();
            GameOver();
        }

        private void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 700)
                pictureBox1.Top=0;
            else
                pictureBox1.Top += speed;
            
            if (pictureBox2.Top >= 700)
                pictureBox2.Top=0;
            else
                pictureBox2.Top += speed; 

            if (pictureBox3.Top >= 700)
                pictureBox3.Top=0;
            else
                pictureBox3.Top += speed; 

            if (pictureBox4.Top >= 700)
                pictureBox4.Top=0;
            else
                pictureBox4.Top += speed;

            if (pictureBox5.Top >= 700)
                pictureBox5.Top=0;
            else
                pictureBox5.Top += speed;

            if (pictureBox6.Top >= 700)
                pictureBox6.Top=0;
            else
                pictureBox6.Top += speed;

            if (pictureBox9.Top >= 700)
                pictureBox9.Top=0;
            else
                pictureBox9.Top += speed;

            if (pictureBox10.Top >= 700)
                pictureBox10.Top=0;
            else
                pictureBox10.Top += speed;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && carImage.Left > 10)
                carImage.Left -= gameSpeed;

            if (e.KeyCode == Keys.D && carImage.Left < 385)
                carImage.Left += gameSpeed;
            
            if (e.KeyCode == Keys.W && gameSpeed < 15)
                gameSpeed++;

            if (e.KeyCode == Keys.S && gameSpeed > 1)
                gameSpeed--;

            if(e.KeyCode==Keys.Escape)
                Application.Exit();
        }


        private void PoliceCar(int speed)
        {
            if (police1.Top >= 700)
            {
                x = random.Next(6, 175);
                police1.Location=new Point(x,0);
            }
            else
                police1.Top += speed;
            

            if (police2.Top >= 700)
            {
                x = random.Next(6, 175);
                police2.Location=new Point(x,0);
            }
            else
                police2.Top += speed;
            
            
            if (police3.Top >= 700)
            {
                x = random.Next(210, 390);
                police3.Location=new Point(x,0);
            }
            else
                police3.Top += speed;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            if (carImage.Bounds.IntersectsWith(police1.Bounds) ||
                carImage.Bounds.IntersectsWith(police2.Bounds) ||
                carImage.Bounds.IntersectsWith(police3.Bounds))
            {
                timer1.Enabled = false;
                gameOver.Visible = true;
            }
        }

        private void Coins(int speed)
        {
            if (coin1.Top >= 700)
            {
                x = random.Next(6, 180);
                coin1.Location = new Point(x, 0);
            }
            else
                coin1.Top += speed;


            if (coin2.Top >= 700)
            {
                x = random.Next(6, 175);
                coin2.Location = new Point(x, 0);
            }
            else
                coin2.Top += speed;


            if (coin3.Top >= 700)
            {
                x = random.Next(210, 390);
                coin3.Location = new Point(x, 0);
            }
            else
                coin3.Top += speed;


            if (coin4.Top >= 700)
            {
                x = random.Next(210, 390);
                coin4.Location = new Point(x, 0);
            }
            else
                coin4.Top += speed;


            if (coin5.Top >= 700)
            {
                x = random.Next(210, 390);
                coin5.Location = new Point(x, 0);
            }
            else
                coin5.Top += speed;
        }

        private void CoinsCollection()
        {
            if (carImage.Bounds.IntersectsWith(coin1.Bounds))
            {
                score++;
                label1.Text = "Coins = " + score.ToString();
                x = random.Next(6, 180);
                coin1.Location = new Point(x, 0);
            }
            
            if (carImage.Bounds.IntersectsWith(coin2.Bounds))
            {
                score++;
                label1.Text = "Coins = " + score.ToString();
                x = random.Next(6, 180);
                coin2.Location = new Point(x, 0);
            }

            if (carImage.Bounds.IntersectsWith(coin3.Bounds))
            {
                score++;
                label1.Text = "Coins = " + score.ToString();
                x = random.Next(210, 390);
                coin3.Location = new Point(x, 0);
            }
            
            if (carImage.Bounds.IntersectsWith(coin4.Bounds))
            {
                score++;
                label1.Text = "Coins = " + score.ToString();
                x = random.Next(210, 390);
                coin4.Location = new Point(x, 0);
            }
            
            if (carImage.Bounds.IntersectsWith(coin5.Bounds))
            {
                score++;
                label1.Text = "Coins = " + score.ToString();
                x = random.Next(210, 390);
                coin5.Location = new Point(x, 0);
            }
        }
    }
}
