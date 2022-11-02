using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int opcion = 0;
        double num = 0.0, res = 0.0;
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
        private void buttonCambioSingo_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Convert.ToString( - Convert.ToInt32(Pantalla.Text));
        }

        //Boton Mas
        private void buttonMas_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text);
            if (res != 0)
            {
                res += num;
                Pantalla.Text = "0";
            }
            else
            {
                res = num;
                Pantalla.Text = "0";
            }
            opcion = 0;
        }
        //Boton Menos
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text);
            if (res != 0)
            {
                res -= num;
                Pantalla.Text = "0";
            }
            else
            {
                res = num;
                Pantalla.Text = "0";
            }
            opcion = 1;
        }
        //Boton Por
        private void buttonPor_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text);
            if (res != 0)
            {
                res *= num;
                Pantalla.Text = "0";
            }
            else
            {
                res = num;
                Pantalla.Text = "0";
            }
            opcion = 2;
        }
        //Boton Division
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text);
            if (res != 0)
            {
                res /= num;
                Pantalla.Text = "0";
            }
            else
            {
                res = num;
                Pantalla.Text = "0";
            }
            opcion = 3;
        }
        //Boton Delete
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1, 1);
            }
            if (Pantalla.Text.Length == 0)
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
            num = 0;
            res = 0;
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text)/100;
            Pantalla.Text = Convert.ToString(num);
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            res = Math.Sqrt(Convert.ToDouble(Pantalla.Text));
            Pantalla.Text = Convert.ToString(res);
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            res = Math.Pow(Convert.ToDouble(Pantalla.Text), 2);
            Pantalla.Text = Convert.ToString(res);
        }

        private void invert_Click(object sender, EventArgs e)
        {
            res = 1/Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = Convert.ToString(res);
        }

        //Boton Igual
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(Pantalla.Text);
            switch (opcion)
            {
                case 0:
                    Pantalla.Text = Convert.ToString(res + num);
                    break;
                case 1:
                    Pantalla.Text = Convert.ToString(res - num);
                    break;
                case 2:
                    Pantalla.Text = Convert.ToString(res * num);
                    break;
                case 3:
                    Pantalla.Text = Convert.ToString(res / num);
                    break;
            }

            opcion = 0;
            num = 0;
        }
    }
}
