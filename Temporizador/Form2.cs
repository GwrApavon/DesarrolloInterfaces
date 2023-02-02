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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Temporizador
{
    public partial class Form2 : Form
    {
        private mainForm mf;
        private int horasS;
        private int minutosS;
        private int segundosS;

        public Form2()
        {
            InitializeComponent();
            mf = new mainForm(this);
            string [] nums = RellenarArray();
            horas.Items.AddRange(nums);
            minutos.Items.AddRange(nums);
            segundos.Items.AddRange(nums);
        }
        
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(horas.Text))
            {
                horasS = 0;            
            }
            else
            {
                horasS = Convert.ToInt32(horas.Text);
            }
            if (string.IsNullOrEmpty(minutos.Text))
            {
                minutosS = 0;
            }
            else
            {
                minutosS = Convert.ToInt32(minutos.Text);
            }
            if (string.IsNullOrEmpty(segundos.Text))
            {
                segundosS = 0;
            }
            else
            {
                segundosS = Convert.ToInt32(segundos.Text);
            }

            mf.count = horasS * 3600 + minutosS * 60 + segundosS;

            if (Popup.Checked)
            {
                mf.popUp = true;
            }
            this.Close();
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
