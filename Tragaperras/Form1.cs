using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tragaperras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            premio1.Visible = false;
            premio2.Visible = false;
            if (Convert.ToInt32(creditos.Text) >= 2)
            {
                creditos.Text = Convert.ToString(Convert.ToInt32(creditos.Text) - 2);
                num1.Text = Convert.ToString(rnd.Next(1, 7));
                num2.Text = Convert.ToString(rnd.Next(1, 7));
                num3.Text = Convert.ToString(rnd.Next(1, 7));

                if(num1.Text == num2.Text || num2.Text == num3.Text 
                  || num1.Text == num3.Text)
                {
                   if(num1.Text == num2.Text && num2.Text == num3.Text)
                    {
                        premio1.Visible = true;
                        creditos.Text = Convert.ToString(Convert.ToInt32(creditos.Text) + 20);
                    }
                    else
                    {
                        #if DEBUG
                        premio2.Visible = true;
                        creditos.Text = Convert.ToString(Convert.ToInt32(creditos.Text) - 5);
                        #else
                        premio2.Visible = true;
                        creditos.Text = Convert.ToString(Convert.ToInt32(creditos.Text) + 5);
                        #endif
                   }
                }
            }
            else
            {
                warning.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            creditos.Text = Convert.ToString(Convert.ToInt32(creditos.Text) + 10);
            warning.Visible = false;
        }
    }
}
