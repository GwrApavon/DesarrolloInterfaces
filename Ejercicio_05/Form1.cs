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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            label2.Text += textBox1.Text;
            label2.Visible = true;
            si.Visible = true;
            no.Visible = true;
        }

        private void si_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            label2.Visible = false;
            si.Visible = false;
            no.Visible = false;
        }

        private void no_Click(object sender, EventArgs e)
        {
            
            label2.Visible = false;
            si.Visible = false;
            no.Visible = false;
        }
    }
}
