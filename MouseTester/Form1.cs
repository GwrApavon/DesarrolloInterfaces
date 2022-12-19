using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTester
{
    public partial class Form1 : Form
    {
        //private string aux;
        public Form1()
        {
          //  aux = Text;
            InitializeComponent();
        }

        private void form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path that is drawn onto the Panel.
            int mouseX = e.X;
            int mouseY = e.Y;

            this.Text = "X: " + mouseX + " Y: " + mouseY;   
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Left.BorderColor = Color.Blue;
                    Left.BackColor = Left.BorderColor;
                    Left.TextColor = Color.White;
                    Right.BorderColor = Color.Red;
                    Right.BackColor = Color.Transparent;
                    Right.TextColor = Color.Black;
                    break;
                case MouseButtons.Right:
                    Right.BorderColor = Color.Red;
                    Right.BackColor = Right.BorderColor;
                    Right.TextColor = Color.White;
                    Left.BorderColor = Color.Blue;
                    Left.BackColor = Color.Transparent;
                    Left.TextColor = Color.Black;
                    break;
                default:
                    Left.BackColor = Color.Green;
                    Left.TextColor = Color.White;
                    Right.BackColor = Color.Green;
                    Right.TextColor = Color.White;
                    Left.BorderColor = Color.Green;
                    Right.BorderColor = Color.Green;
                    break;
            }
        }

        private void Exit_MouseLeave(object sender,EventArgs e)
        {
            Text = "Esperando la entrada del mouse";
        }

        private void Tecla_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Text = "" + e.KeyCode;
        }
        //private void Left_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    if(e.Button == MouseButtons.Left)
        //    {
        //        Left.BackColor = Left.BorderColor;
        //        Left.TextColor = Color.White;
        //    }
        //    else if(base.Left.BackColor == Color.Cyan){

        //        Left.BackColor = Color.Transparent;
        //        Left.TextColor = Color.Black;
        //    }
        //}

        //private void Right_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        Right.BackColor = Right.BorderColor;
        //        Right.TextColor = Color.White;
        //    }
        //    else if (base.Right.BackColor == Color.LightCoral)
        //    {
        //        Right.BackColor = Color.Transparent;
        //        Right.TextColor = Color.Black;
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        
    }
}
