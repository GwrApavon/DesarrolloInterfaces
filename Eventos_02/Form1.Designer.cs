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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.botonURL = new Eventos_02.RJButton();
            this.Swap = new CreacionBotones.BotonPersonalizado2();
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
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(420, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(160, 23);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(419, 20);
            this.url.TabIndex = 6;
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            // 
            // botonURL
            // 
            this.botonURL.BackColor = System.Drawing.Color.Indigo;
            this.botonURL.BackgroundColor = System.Drawing.Color.Indigo;
            this.botonURL.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonURL.BorderRadius = 20;
            this.botonURL.BorderSize = 0;
            this.botonURL.FlatAppearance.BorderSize = 0;
            this.botonURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botonURL.ForeColor = System.Drawing.Color.White;
            this.botonURL.Location = new System.Drawing.Point(585, 7);
            this.botonURL.Name = "botonURL";
            this.botonURL.Size = new System.Drawing.Size(52, 49);
            this.botonURL.TabIndex = 7;
            this.botonURL.Text = "GO";
            this.botonURL.TextColor = System.Drawing.Color.White;
            this.botonURL.UseVisualStyleBackColor = false;
            this.botonURL.Click += new System.EventHandler(this.botonURL_Click);
            this.botonURL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseEnter);
            // 
            // Swap
            // 
            this.Swap.BackColor = System.Drawing.Color.White;
            this.Swap.BackgroundColor = System.Drawing.Color.White;
            this.Swap.BorderColor = System.Drawing.Color.Black;
            this.Swap.BorderRadius = 0;
            this.Swap.BorderSize = 1;
            this.Swap.FlatAppearance.BorderSize = 2;
            this.Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Swap.ForeColor = System.Drawing.Color.Black;
            this.Swap.Location = new System.Drawing.Point(750, 12);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(38, 38);
            this.Swap.TabIndex = 5;
            this.Swap.Text = " ↹";
            this.Swap.TextColor = System.Drawing.Color.Black;
            this.Swap.UseVisualStyleBackColor = false;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            this.Swap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
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
            this.botonRGB.Click += new System.EventHandler(this.BotonRGB_Click);
            this.botonRGB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            this.botonRGB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseEnter);
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
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tecla_KeyDown);
            this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonURL);
            this.Controls.Add(this.url);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonRGB);
            this.Controls.Add(this.exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salida);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private CreacionBotones.BotonPersonalizado2 Swap;
        private System.Windows.Forms.TextBox url;
        private RJButton botonURL;
    }
}

