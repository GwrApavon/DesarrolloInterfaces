namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dato1 = Convert.ToInt32(textBox1.Text);
                int dato2 = Convert.ToInt32(textBox2.Text);
                label3.Text = $"{dato1 + dato2}";
            }
            catch (System.FormatException)
            {
                error.Text = "Datos introducidos no validos";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}