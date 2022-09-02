/*
 * Flappy Bird game
 * Reference: "https://www.mooict.com/create-flappy-bird-game-in-visual-studio-using-c/"
 */
using System;
using System.Windows.Forms;
using System.Media;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // Tốc độ di chuyển (từ phải sang trái) của các trụ
        int gravity = 5;  // Giá trị trọng lực (càng lớn -> chim rơi tự do càng nhanh)
        int score = 0;     // Lưu điểm của lượt chơi
        public Form1()
        {
            InitializeComponent();
        }
        /*public bool StartGame(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Start();
                return true;
            }
            else return false;-68, 245
        }*/
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;
            Random rd = new Random();
            SoundPlayer passpipe = new SoundPlayer(@"D:\HOCTAP\OPP\VS\FlappyBird\FlappyBird\Resources\point.wav");
            SoundPlayer hitpipe = new SoundPlayer(@"D:\HOCTAP\OPP\VS\FlappyBird\FlappyBird\Resources\hit.wav");
            if (pipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = 800;
                pipeBottom.Top = rd.Next(-200,-50);
                score++;
                //if (pipeBottom.Left == flappyBird.Left)
                passpipe.Play();
            }
            if (pipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeTop.Left = 950;
                pipeTop.Top = rd.Next(350, 450);
                score++;
                passpipe.Play();
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
            flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
            flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                hitpipe.Play();
                // if any of the conditions are met from above then we will run the end game function
                EndGame();
            }

            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }
        private void EndGame()
        {
            gameTimer.Stop(); 
            lblScore.Text += " Game over!";
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
               
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
