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
        private MainForm mf = null;
        string[] nums;
        string[] nums2;
        public Form2()
        {
            InitializeComponent();       
        }

        public Form2(Form form)
        {
            mf = form as MainForm;
            InitializeComponent();
            nums = RellenarArray();
            nums2 = RellenarArrayHoras();
            timePicker.Value = DateTime.Now;
            if (mf.Alarm)
            {
                Popup.Visible = false;
                Restart.Visible = false;    
                Crono.Visible = false;   
                horas.Visible = false;
                minutos.Visible = false;
                segundos.Visible = false;
                hrs.Visible = false;
                mnts.Visible = false;
                scds.Visible = false;
                horas.Items.AddRange(nums2);
                minutos.Items.AddRange(nums);
                segundos.Items.AddRange(nums);
            }
            else
            {
                Popup.Visible = true;
                Restart.Visible = true;
                Crono.Visible = true;
                horas.Items.AddRange(nums);
                minutos.Items.AddRange(nums);
                segundos.Items.AddRange(nums);
            }
        }
        
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (mf.Timer)
            {
                if (string.IsNullOrEmpty(horas.Text))
                {
                    mf.horasInicio = 0;
                }
                else
                {
                    mf.horasInicio = Convert.ToInt32(horas.Text); ;
                }
                if (string.IsNullOrEmpty(minutos.Text))
                {
                    mf.minutosInicio = 0;
                }
                else
                {
                    mf.minutosInicio = Convert.ToInt32(minutos.Text);
                }
                if (string.IsNullOrEmpty(segundos.Text))
                {
                    mf.segundosInicio = 0;
                }
                else
                {
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
            }
            if (mf.Alarm)
            {
                 mf.AlarmValue = timePicker.Value;                
            }
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] RellenarArray()
        {
            string[] nums = new string[60];

            nums[0] = "0";
            for (int i = 1; i < 60; i++)
            {
                nums[i] = i.ToString();
            }

            return nums;
        }
        public string[] RellenarArrayHoras()
        {
            string[] nums = new string[13];

            nums[0] = "0";
            for (int i = 1; i < 13; i++)
            {
                nums[i] = i.ToString();
            }

            return nums;
        }

        private void Restart_CheckedChanged(object sender, EventArgs e)
        {
            Crono.Checked = false;
        }

        private void Crono_CheckedChanged(object sender, EventArgs e)
        {
            Restart.Checked = false;
        }
    }
}
