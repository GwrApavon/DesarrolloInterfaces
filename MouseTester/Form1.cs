#define test
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace MouseTester
{ 
    public partial class Form1 : Form
    {
        private string defaultTitle = "Mouse Tester";
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

            this.Text = defaultTitle + " (X: " + mouseX + " Y: " + mouseY + ")";   
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Left.BorderColor = Color.Blue;
                Left.BackColor = Left.BorderColor;
                Left.TextColor = Color.White;
                Right.BorderColor = Color.Red;
                Right.BackColor = Color.Transparent;
                Right.TextColor = Color.Black;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Right.BorderColor = Color.Red;
                Right.BackColor = Right.BorderColor;
                Right.TextColor = Color.White;
            }
            else if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                Left.BackColor = Color.Green;
                Left.TextColor = Color.White;
                Right.BackColor = Color.Green;
                Right.TextColor = Color.White;
                Left.BorderColor = Color.Green;
                Right.BorderColor = Color.Green;
            }
        }

        private void panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Left.BorderColor = Color.Blue;
                Left.BackColor = Color.Transparent;
                Left.TextColor = Color.Black;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Right.BorderColor = Color.Red;
                Right.BackColor = Color.Transparent;
                Right.TextColor = Color.Black;
            }
            else if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                Left.BorderColor = Color.Blue;
                Left.BackColor = Color.Transparent;
                Left.TextColor = Color.Black;
                Right.BorderColor = Color.Red;
                Right.BackColor = Color.Transparent;
                Right.TextColor = Color.Black;
            }

        }
        private void Exit_MouseLeave(object sender,EventArgs e)
        {
            Text = defaultTitle;
        }

        private void Tecla_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            #if test
            this.defaultTitle += " " + e.KeyCode.ToString();
            if (e.KeyCode == System.Windows.Forms.Keys.Escape) this.defaultTitle = "Mouse Tester";
            this.Text = this.defaultTitle;
            #elif DEBUG
            this.defaultTitle += " " + e.KeyValue.ToString();
            if (e.KeyCode == System.Windows.Forms.Keys.Escape) this.defaultTitle = "Mouse Tester";
            this.Text = this.defaultTitle;
            #endif
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, FormClosingEventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("¿Desea salir del programa? ", "Salida",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);

            if (a == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
