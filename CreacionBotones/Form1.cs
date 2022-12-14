using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionBotones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonPersonalizado11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonPersonalizado31_MouseEnter(object sender, EventArgs e)
        {
            botonPersonalizado31.BackColor = botonPersonalizado31.BorderColor;
            botonPersonalizado31.TextColor = Color.White; 
        }
        private void BotonPersonalizado31_MouseLeave(object sender, EventArgs e)
        {
            botonPersonalizado31.BackColor = Color.Transparent;
            botonPersonalizado31.TextColor = Color.Black;
        }

    }
}
