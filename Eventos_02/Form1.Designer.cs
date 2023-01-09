namespace Eventos_02
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.botonRGB = new Eventos_02.RJButton();
            this.exit = new Eventos_02.RJButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(420, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // botonRGB
            // 
            this.botonRGB.BackColor = System.Drawing.Color.Indigo;
            this.botonRGB.BackgroundColor = System.Drawing.Color.Indigo;
            this.botonRGB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonRGB.BorderRadius = 20;
            this.botonRGB.BorderSize = 0;
            this.botonRGB.FlatAppearance.BorderSize = 0;
            this.botonRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botonRGB.ForeColor = System.Drawing.Color.White;
            this.botonRGB.Location = new System.Drawing.Point(526, 70);
            this.botonRGB.Name = "botonRGB";
            this.botonRGB.Size = new System.Drawing.Size(52, 49);
            this.botonRGB.TabIndex = 1;
            this.botonRGB.Text = "GO";
            this.botonRGB.TextColor = System.Drawing.Color.White;
            this.botonRGB.UseVisualStyleBackColor = false;
            this.botonRGB.Click += new System.EventHandler(this.botonRGB_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.BackgroundColor = System.Drawing.Color.Indigo;
            this.exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exit.BorderRadius = 13;
            this.exit.BorderSize = 0;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(194, 407);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(400, 31);
            this.exit.TabIndex = 0;
            this.exit.Text = "Salir";
            this.exit.TextColor = System.Drawing.Color.White;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonRGB);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.salida);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton exit;
        private RJButton botonRGB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

