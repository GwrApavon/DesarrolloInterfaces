using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void add_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Cambio Título", "Desea cambiar el título del formulario?",
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
        }

        public static extern DialogResult Show(string text,
                                         string caption,
                                         MessageBoxButtons buttons,
                                         MessageBoxIcon icon,
                                         MessageBoxDefaultButton defaultButton);
    }

}
