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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salida(object sender, FormClosingEventArgs e)
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
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && !ComprobarURLVisible()) BotonRGB_Click(sender, e);
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && ComprobarURLVisible()) botonURL_Click(sender, e);
        }

        private void BotonRGB_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = Convert.ToInt32(textBox1.Text);
                int valor2 = Convert.ToInt32(textBox2.Text);
                int valor3 = Convert.ToInt32(textBox3.Text);

                valor1 = ComprobarInt(valor1);
                valor2 = ComprobarInt(valor2);
                valor3 = ComprobarInt(valor3);

                if ((valor1 >= 0 && valor1 <= 255) && (valor2 >= 0 && valor2 <= 255) &&
                (valor3 >= 0 && valor3 <= 255))
                {
                    this.BackColor = Color.FromArgb(valor1, valor2, valor3);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private int ComprobarInt(int i)
        {
            if(i < 0) i = 0;
            if(i > 255) i = 255;
            return i;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            url.Visible = false;
            botonURL.Visible = false;
            Cursor = Cursors.Hand;
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            if (ComprobarURLVisible())
            {
                url.Visible= false;
                botonURL.Visible = false;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                botonRGB.Visible = true;
            }
            else
            {
                url.Visible = true;
                botonURL.Visible = true; 

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                botonRGB.Visible = false;
            }
        }

        private bool ComprobarURLVisible()
        {
            if (url.Visible) return true;
            return false;
        }

        private void botonURL_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(url.Text);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button bs = (Button)sender;
            bs.BackColor = Color.White;
            bs.ForeColor = Color.Black;  
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button bs = (Button)sender;
            bs.BackColor = Color.Indigo;
            bs.ForeColor = Color.White;
        }
    }
}
