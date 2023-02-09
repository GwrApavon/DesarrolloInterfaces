using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_MODERNISTA
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirForm <MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();

            //Form existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle= FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag= formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //Form no existe
            else 
            {
                formulario.BringToFront();
            }
        }
        private void UserAcc_Click(object sender, EventArgs e)
        {
            AbrirForm<LogIn>();
            UserAcc.BackColor = Color.FromArgb(45, 55, 69);
        }

        private void Book_Click(object sender, EventArgs e)
        {
            AbrirForm<Libros>();
            Book.BackColor = Color.FromArgb(45, 55, 69);
        }

        private void Member_Click(object sender, EventArgs e)
        {
            AbrirForm<Socios>();
            Member.BackColor = Color.FromArgb(45, 55, 69);
        }

        private void Loan_Click(object sender, EventArgs e)
        {
            AbrirForm<Prestamos>();
            Loan.BackColor = Color.FromArgb(45, 55, 69);
        }

        private void CloseForms(Object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["LogIn"] == null)
            {
                Loan.BackColor = Color.FromArgb(26, 32, 40);
            }
            if (Application.OpenForms["Libros"] == null)
            {
                Loan.BackColor = Color.FromArgb(26, 32, 40);
            }
            if (Application.OpenForms["Socios"] == null)
            {
                Loan.BackColor = Color.FromArgb(26, 32, 40);
            }
            if (Application.OpenForms["Prestamos"] == null)
            {
                Loan.BackColor = Color.FromArgb(26, 32, 40);
            }
        }
    }
}
