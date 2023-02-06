using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Temporizador
{
    public partial class Form2 : Form
    {
        string[] nums;
        public Form2()
        {
            InitializeComponent();       
        }

        public Form2(Form eForm)
        {
            InitializeComponent();
            string[] nums = RellenarArray();
            horas.Items.AddRange(nums);
            minutos.Items.AddRange(nums);
            segundos.Items.AddRange(nums);
        }
        
        private void Aceptar_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(this);
            if (string.IsNullOrEmpty(horas.Text))
            {
                mf.horas = 0;
                mf.horasInicio = 0;
            }
            else
            {
                mf.horas = Convert.ToInt32(horas.Text);
                mf.horasInicio = Convert.ToInt32(horas.Text); ;
            }
            if (string.IsNullOrEmpty(minutos.Text))
            {
                mf.minutos = 0;
                mf.minutosInicio = 0;
            }
            else
            {
                mf.minutos = Convert.ToInt32(minutos.Text);
                mf.minutosInicio = Convert.ToInt32(minutos.Text);
            }
            if (string.IsNullOrEmpty(segundos.Text))
            {
                mf.segundos = 0;
                mf.segundosInicio= 0;
            }
            else
            {
                mf.segundos = Convert.ToInt32(segundos.Text);
                mf.segundosInicio = Convert.ToInt32(segundos.Text);
            }
            if (Popup.Checked)
            {
                mf.popUp = true;
            }
            else
            {
                mf.popUp = false;
            }
            if (Restart.Checked)
            {
                mf.restart = true;
            }
            else
            {
                mf.restart = false;
            }
            if (Crono.Checked)
            {
                mf.crono = true;
            }
            else
            {
                mf.crono = false;
            }
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] RellenarArray()
        {
            string[] nums = new string[100];

            nums[0] = "0";
            for (int i = 1; i < 100; i++)
            {
                nums[i] = i.ToString();
            }

            return nums;
        }
    }
}
