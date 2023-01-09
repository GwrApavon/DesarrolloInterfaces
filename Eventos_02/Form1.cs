using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salida(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)

            {
                
            }

            else
            {
                e.Cancel = true;
            }
        }

        private void Tecla_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)Application.Exit();
            if (e.KeyCode == System.Windows.Forms.Keys.Enter) botonRGB_Click(sender, e);

        }

        private void botonRGB_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBox1.Text);
            int valor2 = Convert.ToInt32(textBox2.Text);
            int valor3 = Convert.ToInt32(textBox3.Text);
            if ((valor1 >= 0 && valor1 <= 255)&& (valor2 >= 0 && valor2 <= 255)&&
                (valor3 >= 0 && valor3 <= 255))
            {
                this.BackColor = Color.FromArgb(valor1, valor2, valor3);
            }
        }
    }
}
