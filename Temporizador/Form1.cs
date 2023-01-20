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

namespace Temporizador
{
    public partial class Form1 : Form
    {
        private int horas;
        private int minutos;
        private int segundos;

        private bool stop;
        public Form1()
        {
            InitializeComponent();
            horas = 0;
            minutos = 4;
            segundos = 0;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(Temporizador);
            if (Start.Text.Equals("START"))
            {
                Start.Text = "STOP";
                td.Start();
            }
            else
            {
                Start.Text = "START";
                try
                {
                    td.Abort();
                }catch(Exception ex)
                {

                }
            } 
        }

        private void Temporizador()
        {
            do
            {
                if (segundos == 0)
                {
                    segundos = 59;
                    minutos--;
                }
                else if (minutos == 0 && segundos == 0)
                {
                    segundos = 59;
                    minutos = 59;
                    horas--;
                }
                else
                {
                    segundos--;
                }
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
                    digits.Text = txtMinutos + ":" + txtSegundos;
                }
                else if (horas != 0)
                {
                    digits.Text = txtHoras + ":" + txtMinutos + ":" + txtSegundos;
                }

                Thread.Sleep(1000);

            } while (horas == 0 && minutos == 0 && segundos == 0);

        }
    }
    
}
