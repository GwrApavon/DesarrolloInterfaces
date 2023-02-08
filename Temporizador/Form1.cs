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
    public partial class MainForm : Form
    {
        public int horasInicio;
        public int minutosInicio;
        public int segundosInicio;
        public int horas;
        public int minutos;
        public int segundos;
        public int count;

        public DateTime AlarmValue;
        public bool popUp;
        public bool restart;
        public bool crono;
        public bool cdStop;

        public bool Timer = true;
        public bool Clock = false;
        public bool Chrono = false;
        public bool Alarm = false;

        //Constructor sin parametros
        public MainForm()
        {
            InitializeComponent();
            popUp = true;
            cdStop = false;
            horas = 0;
            minutos = 0;
            segundos = 5;
            horasInicio = horas;
            minutosInicio = minutos;
            segundosInicio = segundos;
            count = horas * 3600 + minutos * 60 + segundos;
            digits.Text = FormatTimer(count);
        }

        //Constructor sobrecargado
        public MainForm(Form CallingForms)
        {
            InitializeComponent();
            popUp = true;
            horas = 0;
            minutos = 0;
            segundos = 5;
            horasInicio = horas;
            minutosInicio = minutos;
            segundosInicio = segundos;
            count = horas * 3600 + minutos * 60 + segundos;
            digits.Text = FormatTimer(count);
        }

        //Funciones boton start
        private void Start_Click(object sender, EventArgs e)
        {
            if (Timer)
            {
                if (timer3.Enabled)
                {
                    DisableEverything();
                }
                else if (!timer3.Enabled)
                {
                    Iniciar();
                }
            }
            if (Chrono)
            {
                IniciarCrono();
            }
        }

        //Funciones boton Reset
        private void Reset_Click(object sender, EventArgs e)
        {
            if (Timer)
            {
                Reiniciar();
            }
            if (Alarm)
            {
                Thread abrirForm2 = new Thread(LlamadaForm2);
                abrirForm2.Start();
                abrirForm2.Join();
                timer1.Tick += new EventHandler(Alarma);
                timer1.Interval = 1000;
            }
        }

        //Funciones boton edit
        private void Edit_Click(object sender, EventArgs e)
        {
            if (Timer)
            {
                Thread abrirForm2 = new Thread(LlamadaForm2);
                abrirForm2.Start();
                abrirForm2.Join();
                Reiniciar();
            }
            if (Chrono)
            {
                Start.BackColor = Color.Green;
                Start.BorderColor = Color.Green;
                Start.Text = "START";
                timer3.Enabled = false;
                timer3.Tick -= new EventHandler(Cronometro);
                count = 0;
                digits.Text = FormatTimer(count);
            }
        }

        //Inicia el temporizador
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

        //Inicia el cronometro
        private void IniciarCrono()
        {
            if (!timer3.Enabled)
            {
                Start.BackColor = Color.Red;
                Start.BorderColor = Color.Red;
                Start.Text = "STOP";
                timer3.Enabled = true;
                timer3.Tick += new EventHandler(Cronometro);
                timer3.Interval = 1000;
                timer3.Start();
            }
            else
            {
                Start.BackColor = Color.Green;
                Start.BorderColor = Color.Green;
                Start.Text = "START";
                timer3.Enabled = false;
                timer3.Tick -= new EventHandler(Cronometro);
            }
        }

        //Funcion temporizador
        private void Temporizador(object sender, EventArgs e)
        {
            if (count > 0 && !cdStop)
            {
                count--;
                digits.Text = FormatTimer(count);
            }
            if (count == 0)
            {  
                timer2.Stop();
                if (popUp)
                {
                    MessageBox.Show("Se ha terminado el tiempo", "Temporizador");
                }
                if (restart)
                {
                    timer2.Start();
                    Reiniciar();
                }        
                if (!restart && !crono)
                {
                    Start.BackColor = Color.Green;
                    Start.BorderColor = Color.Green;
                    Start.Text = "START";
                }
                if (crono && count == 0)
                {
                    cdStop = true;
                    timer3.Enabled = true;
                    timer3.Tick += new EventHandler(Cronometro);
                    timer3.Interval = 1000;
                    timer3.Start();
                }
            }     
        }

        //Funcion reloj
        private void Timer1_Tick(object sender, EventArgs e)
        { 
            digits.Text = DateTime.Now.ToLongTimeString();
        }

        //Funcion reinicio
        private void Reiniciar()
        {
            count = horasInicio * 3600 + minutosInicio * 60 + segundosInicio;
            digits.Text = FormatTimer(count);
        }

        //Funcion cronometro
        private void Cronometro(object sender, EventArgs e)
        {
            count+=1;
            digits.Text = FormatTimer(count);
            
        }

        //Funcion Alarma
        private void Alarma(object sender, EventArgs e)
        {
            DateTime current_Time = DateTime.Now;

            if (current_Time.Hour == AlarmValue.Hour &&
               current_Time.Minute == AlarmValue.Minute &&
               current_Time.Second == AlarmValue.Second)
            {
                MessageBox.Show("Se ha terminado el tiempo", "Alarma");
            }
        }

        //Cambia a temporizador
        private void Timer_Click(object sender, EventArgs e)
        {
            if (!Timer)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;

                Start.Visible = true;
                Reset.Visible = true;
                Edit.Visible = true;
                Edit.Text = "EDIT";
                Edit.BackColor = Color.CornflowerBlue;
                Reset.Text = "RESET";
                Reset.BackColor = Color.Orange;
                digits.Text = minutosInicio + ":" + segundosInicio;

                Timer = true;
                Clock = false;
                Chrono = false; 
                Alarm = false;
            }
        }

        //Cambia a reloj
        private void Reloj_Click(object sender, EventArgs e)
        {
            if (!Clock)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = false;
                
                Start.Visible = false;
                Reset.Visible = false;
                Edit.Visible = false;
                
                Timer = false;
                Clock = true;
                Chrono = false;
                Alarm = false;
            }
        }

        //Cambia a cronometro
        private void Crno_Click(object sender, EventArgs e)
        {
            if (!Chrono)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = true;

                count = 0;
                digits.Text = FormatTimer(count);
                Start.Visible = true;
                Reset.Visible = false;
                Edit.Visible = true;
                Edit.Text = "RESTART";
                Edit.BackColor = Color.CornflowerBlue;
                
                Timer = false;
                Clock = false;
                Chrono = true;
                Alarm = false;
            }
        }

        //Cambia a alarma
        private void Alarm_Click(object sender, EventArgs e)
        {
            if (!Alarm)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = false;

                Start.Visible = false;
                Edit.Visible = false;
                Reset.Text = "HABILITAR ALARMA";
                Reset.BackColor = Color.CornflowerBlue;
                
                Timer = false;
                Clock = false;
                Chrono = false;
                Alarm = true;

                
            }
        }

        //Deshabilita todos los timers
        private void DisableEverything()
        {
            Start.BackColor = Color.Green;
            Start.BorderColor = Color.Green;
            Start.Text = "START";
            timer2.Enabled = false;
            timer2.Tick -= new EventHandler(Temporizador);
            timer3.Enabled = false;
            timer3.Tick -= new EventHandler(Cronometro);
        }

        //Llama al 2do form
        private void LlamadaForm2()
        {
            Form2 fm2 = new Form2(this);
            fm2.ShowDialog();
        }

        //Formatea el texto del tiempo
        private string FormatTimer(int count)
        {
            horas = count / 3600;
            minutos = count / 60 % 60;
            segundos = count % 60;
            string txtSegundos = segundos.ToString();
            string txtMinutos = minutos.ToString();
            string txtHoras = horas.ToString();

            if (txtSegundos.Length <= 1)
            {
                txtSegundos = "0" + txtSegundos;
            }
            else if (txtMinutos.Length <= 1)
            {
                txtMinutos = "0" + txtMinutos;
            }
            else if (txtHoras.Length <= 1)
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
    }
    
}
