namespace Temporizador
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
            this.Start = new CreacionBotones.BotonPersonalizado2();
            this.Edit = new CreacionBotones.BotonPersonalizado2();
            this.Reset = new CreacionBotones.BotonPersonalizado2();
            this.digits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightGray;
            this.Start.BackgroundColor = System.Drawing.Color.LightGray;
            this.Start.BorderColor = System.Drawing.Color.LightGray;
            this.Start.BorderRadius = 0;
            this.Start.BorderSize = 1;
            this.Start.FlatAppearance.BorderSize = 2;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(498, 335);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(150, 40);
            this.Start.TabIndex = 0;
            this.Start.Text = "START";
            this.Start.TextColor = System.Drawing.Color.Black;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.LightGray;
            this.Edit.BackgroundColor = System.Drawing.Color.LightGray;
            this.Edit.BorderColor = System.Drawing.Color.LightGray;
            this.Edit.BorderRadius = 0;
            this.Edit.BorderSize = 1;
            this.Edit.FlatAppearance.BorderSize = 2;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Location = new System.Drawing.Point(149, 335);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(150, 40);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "EDIT";
            this.Edit.TextColor = System.Drawing.Color.Black;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.LightGray;
            this.Reset.BackgroundColor = System.Drawing.Color.LightGray;
            this.Reset.BorderColor = System.Drawing.Color.LightGray;
            this.Reset.BorderRadius = 0;
            this.Reset.BorderSize = 1;
            this.Reset.FlatAppearance.BorderSize = 2;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(324, 335);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(150, 40);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "RESET";
            this.Reset.TextColor = System.Drawing.Color.Black;
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // digits
            // 
            this.digits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digits.AutoSize = true;
            this.digits.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digits.Location = new System.Drawing.Point(259, 136);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(304, 114);
            this.digits.TabIndex = 7;
            this.digits.Text = "04:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreacionBotones.BotonPersonalizado2 Start;
        private CreacionBotones.BotonPersonalizado2 Edit;
        private CreacionBotones.BotonPersonalizado2 Reset;
        private System.Windows.Forms.Label digits;
    }
}

