using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using Timer = System.Windows.Forms.Timer;
using System.Reflection;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Temporizador
{
    public partial class mainForm : Form
    {
        private const string HORAS = "0";
        private const string MINUTOS = "0";
        private const string SEGUNDOS = "5";
        private int horas;
        private int minutos;
        private int segundos;
        public int count;
        public bool popUp;
        public mainForm()
        {
            InitializeComponent();
            horas = Convert.ToInt32(HORAS);
            minutos = Convert.ToInt32(MINUTOS);
            segundos = Convert.ToInt32(SEGUNDOS);
            count = horas * 3600 + minutos * 60 + segundos;
            digits.Text = FormatTimer(count);
        }
        public mainForm(Form callingForms)
        {     
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            Thread abrirForm2 = new Thread(LlamadaForm2);
            abrirForm2.Start();
            abrirForm2.Join();
            digits.Text = FormatTimer(count);
        }

        private void LlamadaForm2() 
        { 
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                Start.BackColor = Color.Red;
                Start.BorderColor = Color.Red;
                Start.Text = "STOP";
                timer2.Enabled = true;
                timer2.Tick += new EventHandler(Temporizador);
                timer2.Interval = 1000;
                timer2.Start();
            }
            else
            {
                Start.BackColor = Color.Green;
                Start.BorderColor = Color.Green;
                Start.Text = "START";
                timer2.Enabled = false;
                timer2.Tick -= new EventHandler(Temporizador);
            }
            
            
        }

        private void Temporizador(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer2.Stop();
                Start.BackColor = Color.Green;
                Start.BorderColor = Color.Green;
                Start.Text = "START";
                timer2.Enabled = false;
                if (popUp)
                {
                    MessageBox.Show("Se ha terminado el tiempo", "Temporizador");
                }

            }
            if (count > 0)
            {
                count--;
                digits.Text = FormatTimer(count);  
            }
        }

        private string FormatTimer(int count)
        {
            horas = count / 3600;
            minutos = count / 60 % 60;
            segundos = count % 60;
            string txtSegundos = segundos.ToString();
            string txtMinutos = minutos.ToString();
            string txtHoras = horas.ToString();

            if (txtSegundos.Length == 1)
            {
                txtSegundos = "0" + txtSegundos;
            }
            else if (txtMinutos.Length == 1)
            {
                txtMinutos = "0" + txtMinutos;
            }
            else if (txtHoras.Length == 1)
            {
                txtHoras = "0" + txtHoras;
            }
            if (horas == 0)
            {
                return txtMinutos + ":" + txtSegundos;
            }
            else if (horas != 0)
            {
                return txtHoras + ":" + txtMinutos + ":" + txtSegundos;
            }
            return "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        { 
            digits.Text = DateTime.Now.ToLongTimeString();
        }

        private void Reloj_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Start.Visible = false;
            Reset.Visible = false;
            Edit.Visible = false;
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            if (!Start.Visible)
            { 
                timer1.Enabled = false;
                Start.Visible = true;
                Reset.Visible = true;
                Edit.Visible = true;
                digits.Text = MINUTOS + ":" + SEGUNDOS;
            }
        }
    }
    
}
