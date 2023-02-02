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
        private int horasInicio;
        private int minutosInicio;
        private int segundosInicio;
        private int horas;
        private int minutos;
        private int segundos;
        public int count;
        public bool popUp;
        public bool restart;
        public bool crono;
        public mainForm()
        {
            InitializeComponent();
            popUp = true;
            restart = true;
            crono = false;
            horas = 0;
            minutos = 0;
            segundos = 5;
            horasInicio = horas;
            minutosInicio = minutos;
            segundosInicio = segundos;
            count = horas * 3600 + minutos * 60 + segundos;
            digits.Text = FormatTimer(count);
        }
        public mainForm(Form callingForms)
        {
            popUp = true;
            restart = true;
            crono= false;
            horas = 0;
            minutos = 4;
            segundos = 0;
            horasInicio = horas;
            minutosInicio = minutos;
            segundosInicio = segundos;
            count = horas * 3600 + minutos * 60 + segundos;
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
            Iniciar();

        }

        private void Iniciar()
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
                if (restart)
                {
                    Reiniciar();
                }
                if (crono)
                {
                    //Cronometro();
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
                digits.Text = minutosInicio + ":" + segundosInicio;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void Reiniciar()
        {
            count = horasInicio * 3600 + minutosInicio * 60 + segundosInicio;
            digits.Text = FormatTimer(count);
        }
    }
    
}
