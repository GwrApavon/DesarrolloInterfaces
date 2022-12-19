namespace MouseTester
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Left = new MouseTester.BotonPersonalizado3();
            this.Right = new MouseTester.BotonPersonalizado3();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Transparent;
            this.Left.BackgroundColor = System.Drawing.Color.Transparent;
            this.Left.BorderColor = System.Drawing.Color.Blue;
            this.Left.BorderRadius = 0;
            this.Left.BorderSize = 2;
            this.Left.FlatAppearance.BorderSize = 2;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.ForeColor = System.Drawing.Color.Black;
            this.Left.Location = new System.Drawing.Point(148, 292);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(150, 40);
            this.Left.TabIndex = 0;
            this.Left.Text = "Left";
            this.Left.TextColor = System.Drawing.Color.Black;
            this.Left.UseVisualStyleBackColor = false;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Transparent;
            this.Right.BackgroundColor = System.Drawing.Color.Transparent;
            this.Right.BorderColor = System.Drawing.Color.Crimson;
            this.Right.BorderRadius = 0;
            this.Right.BorderSize = 2;
            this.Right.FlatAppearance.BorderSize = 2;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.ForeColor = System.Drawing.Color.Black;
            this.Right.Location = new System.Drawing.Point(407, 292);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(150, 40);
            this.Right.TabIndex = 1;
            this.Right.Text = "Right";
            this.Right.TextColor = System.Drawing.Color.Black;
            this.Right.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Name = "Form1";
            this.Text = "Esperando entrada del mouse";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private BotonPersonalizado3 Left;
        private BotonPersonalizado3 Right;
    }
}

