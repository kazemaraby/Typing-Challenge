using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace TypingChallenge
{

    public partial class Form1 : Form
    {
        
                
        int score = 0;

        int lives = 5;

        public string[] words = { "dog", "book", "rabbit", "lion", "tiger", "orange"
                , "apple", "phone", "computer", "banana", "mango", "melon", "strawberry"
                , "watermelon", "apricot", "fig", "cocunt", "cat", "duck", "cow"
                , "horse", "sheep", "pig", "donkey", "goat","hen","snail","chameleon"
                ,"deer","koala","wolf","snake","bat","eagle","turtle","octopus","frog"
                ,"whale","crab","clam","lobster","bee","butterfly","owl","penguin" };
        public string[] arr = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<Bitmap> lisImage = new List<Bitmap>();
        //vertical direction value from 700 to 0 (down to up) y-Axis value
        int timer = 700;
        int timer2 = 700;
        int timer3 = 700;
        static Random random = new Random();
        static Random random2 = new Random();
        static Random random3 = new Random();
      
        //Horizontal direction value from 100 to 1000 (left to right) X-Axis value
        int RandomNum = random.Next(100, 1000);
        int RandomNum2 = random2.Next(100, 1000);
        int RandomNum3 = random3.Next(100, 1000);


        public void showButtonText(Button b)
        {
            b.Location = new Point(random.Next(100, 1000), 700);
            b.Text = arr[random.Next(0, 26)].ToString();
            b.Visible = true;
        }

        public void showButtonWord(Button b)
        {

            b.Location = new Point(random.Next(100, 1000), 700);
            b.Text = words[random.Next(0, 44)].ToString();
            b.Width = 25;
            b.Height = 25;
            b.Height = b.Text.Length * b.Height;
            b.Width = b.Text.Length * b.Width;
            b.Visible = true;
        }

        public void MoveButton(Button b)
        {
            timer = 700;
            b.Text = arr[random.Next(0, 25)].ToString();
            RandomNum = random.Next(100, 1000);
        }
        public string RandomStringGenerator()
        {
            string NewChar = arr[random.Next(0, 25)].ToString();
            return NewChar;
        }

        //View controls & background music in start button
        SoundPlayer simpleSound = new SoundPlayer(@"C:\1.wav");
        public void Viewcontrols()
        {
            // background music
           
            simpleSound.PlayLooping();
            //View controls
            MovingButton.Text = arr[random.Next(0, 25)].ToString();
            timer1.Enabled = true;
            StartButton.Hide();
            LivesLabel.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            ScoreLabel.Visible = true;
            InputText.Visible = true;
            Life1.Visible = true;
            Life2.Visible = true;
            Life3.Visible = true;
            Life4.Visible = true;
            Life5.Visible = true;
            resume.Visible = true;
            pause.Visible = true;
            Mute.Visible = true;
            userName.Visible = true;
            controlPanel.Visible = true;
            LifeHeartPanel.Visible = true;
            InputText.Focus();
           
        }

        public void GameOver()
        {
            timer1.Stop();
            MovingButton.Visible = false;
            MovingButton2.Visible = false;
            MovingButton3.Visible = false;
            MessageBox.Show("Game Over");
            string msg = "Do you want to play again ? ";
            string title = "Play again ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, title, buttons);
            if (result == DialogResult.No)
            {
                Application.Exit();
                this.Close();
            }
            else
            {
                Application.Restart();
                
            }           
        }

        public void DecreaseLives()
        {
            lives--;
            LivesLabel.Text = lives.ToString();
            if (lives == 4)
                Life1.Visible = false;
            if (lives == 3)
            {
                Life1.Visible = false;
                Life2.Visible = false;
            }
            if (lives == 2)
            {
                Life1.Visible = false;
                Life2.Visible = false;
                Life3.Visible = false;
            }
            if (lives == 1)
            {
                Life1.Visible = false;
                Life2.Visible = false;
                Life3.Visible = false;
                Life4.Visible = false;
            }
            if (lives == 0)
            {
                Life1.Visible = false;
                Life2.Visible = false;
                Life3.Visible = false;
                Life4.Visible = false;
                Life5.Visible = false;
                GameOver();
            }
        }
        //create list of imges from resources and change the background img every 1 secondes
       public Timer backImgTimer = new Timer();
        public void changeBackImg()
        {
            lisImage.Add(Properties.Resources._2);
            lisImage.Add(Properties.Resources._3);
            lisImage.Add(Properties.Resources._4);
            lisImage.Add(Properties.Resources._5);
            lisImage.Add(Properties.Resources._6);
            lisImage.Add(Properties.Resources._7);
            lisImage.Add(Properties.Resources._8);
            lisImage.Add(Properties.Resources._9);
            lisImage.Add(Properties.Resources._10);
            lisImage.Add(Properties.Resources._11);
            lisImage.Add(Properties.Resources._12);
            lisImage.Add(Properties.Resources._13);
            lisImage.Add(Properties.Resources._14);
            lisImage.Add(Properties.Resources._15);
            lisImage.Add(Properties.Resources._20);
            lisImage.Add(Properties.Resources._21);
            lisImage.Add(Properties.Resources._22);
            lisImage.Add(Properties.Resources._23);
            lisImage.Add(Properties.Resources._24);
            lisImage.Add(Properties.Resources._25);
            lisImage.Add(Properties.Resources._26);
            lisImage.Add(Properties.Resources._27);
            lisImage.Add(Properties.Resources._28);
            lisImage.Add(Properties.Resources._29);
            lisImage.Add(Properties.Resources._30);
            lisImage.Add(Properties.Resources._31);
            lisImage.Add(Properties.Resources._32);
            lisImage.Add(Properties.Resources._33);
            lisImage.Add(Properties.Resources._34);
            lisImage.Add(Properties.Resources._35);
            lisImage.Add(Properties.Resources._36);
            lisImage.Add(Properties.Resources._37);
            lisImage.Add(Properties.Resources._38);
            backImgTimer.Interval = 10000;
            backImgTimer.Tick += new EventHandler(timer1_Tick);
            backImgTimer.Start();
        }
      
        public Form1(string salut ,string fname,string lname)
        {
            InitializeComponent();
            userName.Text = $"{salut} {fname} {lname}";
            userName.Font= new Font("regular", 16, FontStyle.Bold);
        }
        bool TimerFlag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimerFlag == true)
            {
                //change back img
                if (lives != 0)
                {
                    
                    var indexbackimage = ((DateTime.Now.Second)/2) % lisImage.Count;
                    this.BackgroundImage = lisImage[indexbackimage];
                }
                //---------------------------------------------------------------start to move textBxes 
                MovingButton.Visible = true;
                //timer is 700 now and decreasing
                timer -= 5;

                if (score > 9 || score > 39)
                {
                    timer2 -= 5;
                }

                if (score > 19 || score > 49)
                {
                    timer3 -= 5;
                }
                //mving text location from bottom to top 
                MovingButton.Location = new Point(RandomNum, timer);
                MovingButton2.Location = new Point(RandomNum2, timer2);
                MovingButton3.Location = new Point(RandomNum3, timer3);
                //when we reach the top (5 because of the input textbox) 
                if (timer == 5 && score < 30)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer = 700;
                    showButtonText(MovingButton);
                }

                else if (timer == 5 && score > 29)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer = 700;
                    showButtonWord(MovingButton);
                }

                if (timer2 == 5 && score < 30)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer2 = 700;
                    showButtonText(MovingButton2);
                }

                else if (timer2 == 5 && score > 39)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer2 = 700;
                    showButtonWord(MovingButton2);
                }

                if (timer3 == 5 && score < 30)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer3 = 700;
                    showButtonText(MovingButton3);
                }

                else if (timer3 == 5 && score > 49)
                {
                    DecreaseLives();
                    //re generate a new char from the bottom
                    timer3 = 700;
                    showButtonWord(MovingButton3);
                }
            }
        }

       
        private void StartButton_Click(object sender, EventArgs e)
        {
            Viewcontrols();
            changeBackImg();
           
        }
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            if (InputText.Text.Length == MovingButton.Text.Length || InputText.Text.Length == MovingButton2.Text.Length || InputText.Text.Length == MovingButton3.Text.Length)
            {
                if (InputText.Text == MovingButton.Text)
                {
                    score++;
                    // toggle between char and word
                    if (score < 30)
                    {
                        showButtonText(MovingButton);
                    }
                    
                    else if (score > 29)
                    {
                        showButtonWord(MovingButton);
                    }
                    /////////////////
                    

                    if (score == 5)
                    {
                       //increase speed
                        timer1.Interval /= 2;
                    }
                    if (score == 10)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 2");
                        timer1.Start();
                        timer2 = 700;

                        //show 2 chars instead of one
                        showButtonText(MovingButton2);
                    }

                 

                    if (score == 20)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 3");
                        timer1.Start();
                        timer3 = 700;

                        //show 3 chars instead of 2
                        showButtonText(MovingButton3);
                    }
                    if (score == 30)
                    {
                        MovingButton.Visible = false;
                        MovingButton.Text = "أ";

                        MovingButton2.Visible = false;
                        MovingButton2.Text = "أ";

                        MovingButton3.Visible = false;
                        MovingButton3.Text = "أ";

                        timer1.Stop();
                        MessageBox.Show("Level 4");
                        timer1.Start();
                        timer = 700;

                        //show just 1 word
                        showButtonWord(MovingButton);
                    }

                    if (score == 40)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 5");
                        timer1.Start();                       
                        timer2 = 700;

                        //show 2 words
                        showButtonWord(MovingButton2);                                              
                    }

                    if (score == 50)
                    {
                        timer1.Stop();
          
                        MessageBox.Show("Level 6");
                        timer1.Start();                        
                        timer3 = 700;  
                        
                        //show 3 words
                        showButtonWord(MovingButton3);
                        
                        //increase speed
                        timer1.Interval *= 2;
                    }

                    if (score == 60)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 7");
                        timer1.Start();
                        
                        timer3 = 700;                                                
                        //showButtonWord(MovingButton3);                       
                    }

                    if (score == 70)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 8");
                        timer1.Start();

                        timer3 = 700;                        
                       // showButtonWord(MovingButton3);
                        //timer1.Interval /= 2;
                    }

                    ScoreLabel.Text = score.ToString();
                    timer = 700;
                    RandomNum = random.Next(100, 1000);
                    InputText.Clear();
                    
                }
                else if (InputText.Text == MovingButton2.Text)
                {
                    score++;


                    if (score > 9 && score < 30)
                    {
                        showButtonText(MovingButton2);
                    }

                    else if (score > 39)
                    {
                        showButtonWord(MovingButton2);
                    }


                    if (score == 20)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 3");
                        timer1.Start();
                        timer3 = 700;
                        showButtonText(MovingButton3);
                        //timer1.Interval /= 5;
                    }

                    if (score == 30)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 4");
                        timer1.Start();

                        MovingButton.Visible = false;
                        MovingButton.Text="أ";

                        MovingButton2.Visible = false;
                        MovingButton2.Text = "أ";
                        
                        MovingButton3.Visible = false;
                        MovingButton3.Text = "أ";
                        //timer1.Interval *= 10;
                        timer = 700;
                        showButtonWord(MovingButton);
                        //timer1.Interval *= 4;
                    }

                    if (score == 50)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 5");
                        timer1.Start();

                        timer3 = 700;
                        showButtonWord(MovingButton3);
                        //timer1.Interval /= 5;
                    }

                    ScoreLabel.Text = score.ToString();
                    InputText.Clear();
                    timer2 = 700;
                    RandomNum2 = random.Next(100, 1000);
                }

                else if (InputText.Text == MovingButton3.Text)
                {
                    score++;

                    if (score > 19 && score < 30)
                    {
                        showButtonText(MovingButton3);
                    }



                    if (score == 30)
                    {
                        timer1.Stop();
                        MessageBox.Show("Level 4");
                        timer1.Start();
                        MovingButton.Visible = false;
                        MovingButton.Text = "أ";

                        MovingButton2.Visible = false;
                        MovingButton2.Text = "أ";

                        MovingButton3.Visible = false;
                        MovingButton3.Text = "أ";
                        //timer1.Interval *= 10;
                        timer = 700;
                        showButtonWord(MovingButton);
                        //timer1.Interval /= 4;
                    }

                    if (score > 49)
                    {

                        showButtonWord(MovingButton3);
                    }

                    ScoreLabel.Text = score.ToString();
                    timer3 = 700;
                    RandomNum3 = random.Next(100, 1000);
                    InputText.Clear();
                }

                else if (InputText.Text.Length >= (Math.Max(Math.Max(MovingButton.Text.Length, MovingButton2.Text.Length), MovingButton3.Text.Length)))
                {
                    InputText.Clear();
                }
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            TimerFlag = false;
            
            timer1.Stop();
            InputText.ReadOnly = true;
            simpleSound.Stop();
            backImgTimer.Stop();
            MessageBox.Show("Game Paused");


        }

        private void resume_Click(object sender, EventArgs e)
        {
            TimerFlag = true;

            MessageBox.Show("Press ok to Resume Game ");
            timer1.Start();
            InputText.ReadOnly = false;
            simpleSound.PlayLooping();
            backImgTimer.Start();
            InputText.Focus();


        }

       
        //if sound played mute it .. else replay again
        bool flag = true;
        private void Mute_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                simpleSound.Stop();
                flag = false;
            }
            else 
            {
                simpleSound.PlayLooping();
                flag = true;
            }
        }
    }
}


