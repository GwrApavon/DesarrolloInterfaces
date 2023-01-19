using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;

namespace SimonDice
{
    public partial class Form1 : Form
    {
        int SecuenceControl = 0;
        Random Rnd;
        int time = 500;

        List<int> SimonSays = new List<int>();
        bool Speaking = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public Form1()
        {
            InitializeComponent();
            Rnd = new Random();
        }

        public void VerifyPressedButton(int buttonValue)
        {
            if (Speaking || SimonSays.Count == 0) return;
            if (SimonSays[SecuenceControl] == buttonValue) SecuenceControl++;
            else
            {
                MessageBox.Show("Tu Record Final es:" + SimonSays.Count);
                SecuenceControl = 0;
                SimonSays = new List<int>();
                Speaking = false;
            }
            if (SecuenceControl >= SimonSays.Count)
            {
                SecuenceControl = 0;
                SimonSays.Add(Rnd.Next(0,4));
                Thread.Sleep(1000);
            }
            score.Text = SimonSays.Count.ToString();
        }
        public void GameStart()
        {
            Thread.Sleep(time);
            Speaking= true;
            foreach(int Active in SimonSays)
            {
                switch(Active)
                {
                    case 0:
                        button_0.Image = Properties.Resources.SimonDiceBlueShiny;
                        Thread.Sleep(time);
                        button_0.Image = Properties.Resources.SimonDiceBlue;
                        break;
                    case 1:
                        button_1.Image = Properties.Resources.SimonDiceGreenShiny;
                        Thread.Sleep(time);
                        button_1.Image = Properties.Resources.SimonDiceGreen;
                        break;
                    case 2:
                        button_2.Image = Properties.Resources.SimonDiceRedShiny;
                        Thread.Sleep(time);
                        button_2.Image = Properties.Resources.SimonDiceRed;
                        break;
                    case 3:
                        button_3.Image = Properties.Resources.SimonDiceYellowShiny;
                        Thread.Sleep(time);
                        button_3.Image = Properties.Resources.SimonDiceYellow;
                        break;
                }
                Thread.Sleep(time);
            }
            Speaking= false;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            SimonSays.Add(Rnd.Next(0, 4));
            new Thread(GameStart).Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            String Pressed = ((PictureBox)sender).Name;
            string[] NumberButton = Pressed.Split('_');
            VerifyPressedButton(Convert.ToInt32(NumberButton[1]));
            SoundPlayer s;

            try
            {
                s = new SoundPlayer(Application.StartupPath + @"\resources\pong.wav");
                s.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void Bluebutton_MouseDown(object sender, MouseEventArgs e)
        {
            button_0.Image = Properties.Resources.SimonDiceBlueShiny;
        }

        private void Bluebutton_MouseUp(object sender, MouseEventArgs e)
        {
            button_0.Image = Properties.Resources.SimonDiceBlue;
        }
        private void Greenbutton_MouseDown(object sender, MouseEventArgs e)
        {
            button_1.Image = Properties.Resources.SimonDiceGreenShiny;
        }

        private void Greenbutton_MouseUp(object sender, MouseEventArgs e)
        {
            button_1.Image = Properties.Resources.SimonDiceGreen;
        }
        private void Redbutton_MouseDown(object sender, MouseEventArgs e)
        {
            button_2.Image = Properties.Resources.SimonDiceRedShiny;
        }

        private void Redbutton_MouseUp(object sender, MouseEventArgs e)
        {
            button_2.Image = Properties.Resources.SimonDiceRed;
        }
        private void Yellowbutton_MouseDown(object sender, MouseEventArgs e)
        {
            button_3.Image = Properties.Resources.SimonDiceYellowShiny;
        }

        private void Yellowbutton_MouseUp(object sender, MouseEventArgs e)
        {
            button_3.Image = Properties.Resources.SimonDiceYellow;
        }

        //public void ReproducirMusica()
        //{
        //    SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.p);
        //    sndplayr.Play();
        //}
    }
}
