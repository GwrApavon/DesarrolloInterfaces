using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
         int opcion = 0;
         double num1 = 0.0, num2 = 0.0;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "0";
            }
            else
            {
                Pantalla.Text += "0";
            }
        }
        //Boton 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "1";
            }
            else
            {
                Pantalla.Text += "1";
            }
        }
        //Boton 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "2";
            }
            else
            {
                Pantalla.Text += "2";
            }
        }
        //Boton 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "3";
            }
            else
            {
                Pantalla.Text += "3";
            }
        }
        //Boton 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "4";
            }
            else
            {
                Pantalla.Text += "4";
            }
        }
        //Boton 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "5";
            }
            else
            {
                Pantalla.Text += "5";
            }
        }
        //Boton 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "6";
            }
            else
            {
                Pantalla.Text += "6";
            }
        }
        //Boton 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "7";
            }
            else
            {
                Pantalla.Text += "7";
            }
        }
        //Boton 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "8";
            }
            else
            {
                Pantalla.Text += "8";
            }
        }
        //Boton 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "9";
            }
            else
            {
                Pantalla.Text += "9";
            }
        }

        //Boton Punto
        private void buttonDot_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ",";
        }
        //Boton MasMenos
        private void buttonMasMenos_Click(object sender, EventArgs e)
        {

        }
       
        //Boton Mas
        private void buttonMas_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            opcion = 0;
            Pantalla.Text = "0";
        }
        //Boton Menos
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            opcion = 1;
            Pantalla.Text = "0";
        }
        //Boton Por
        private void buttonPor_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            opcion = 2;
            Pantalla.Text = "0";
        }
        //Boton Division
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            opcion = 3;
            Pantalla.Text = "0";
        }
        //Boton Delete
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1, 1);
            }
            if(Pantalla.Text.Length == 0)
            {
                Pantalla.Text = "0";
            }
        }
        //Boton C
        private void buttonC_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
        }
        //Boton CE
        private void buttonCE_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            opcion = 0;
            num1 = 0;
            num2 = 0;
        }
        //Boton Igual
         private void buttonIgual_Click(object sender, EventArgs e)
         {
            num2 = Convert.ToDouble(Pantalla.Text);
             switch (opcion)
             {
                 case 0:
                     Pantalla.Text = Convert.ToString(num1 + num2);
                     break;
                 case 1:
                     Pantalla.Text = Convert.ToString(num1 - num2);
                     break;
                 case 2:
                     Pantalla.Text = Convert.ToString(num1 * num2);
                     break;
                 case 3:
                     Pantalla.Text = Convert.ToString(num1 / num2);
                     break;
             }
        }
    }
    }
