namespace CreacionBotones
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
            this.rjButton1 = new CreacionBotones.RJButton();
            this.botonPersonalizado11 = new CreacionBotones.BotonPersonalizado1();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // botonPersonalizado11
            // 
            this.botonPersonalizado11.BackColor = System.Drawing.Color.DarkGray;
            this.botonPersonalizado11.BackgroundColor = System.Drawing.Color.DarkGray;
            this.botonPersonalizado11.BorderColor = System.Drawing.Color.Gold;
            this.botonPersonalizado11.BorderRadius = 10;
            this.botonPersonalizado11.BorderSize = 2;
            this.botonPersonalizado11.FlatAppearance.BorderSize = 2;
            this.botonPersonalizado11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado11.ForeColor = System.Drawing.Color.Black;
            this.botonPersonalizado11.Location = new System.Drawing.Point(12, 79);
            this.botonPersonalizado11.Name = "botonPersonalizado11";
            this.botonPersonalizado11.Size = new System.Drawing.Size(150, 40);
            this.botonPersonalizado11.TabIndex = 2;
            this.botonPersonalizado11.Text = "botonPersonalizado11";
            this.botonPersonalizado11.TextColor = System.Drawing.Color.Black;
            this.botonPersonalizado11.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonPersonalizado11);
            this.Controls.Add(this.rjButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RJButton rjButton1;
        private BotonPersonalizado1 botonPersonalizado11;
    }
}

