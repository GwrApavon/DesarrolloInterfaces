namespace Temporizador
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.digits = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new CreacionBotones.BotonPersonalizado2();
            this.Reloj = new CreacionBotones.BotonPersonalizado2();
            this.Reset = new CreacionBotones.BotonPersonalizado2();
            this.Edit = new CreacionBotones.BotonPersonalizado2();
            this.Start = new CreacionBotones.BotonPersonalizado2();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Crno = new CreacionBotones.BotonPersonalizado2();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // digits
            // 
            this.digits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digits.AutoSize = true;
            this.digits.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digits.Location = new System.Drawing.Point(216, 135);
            this.digits.MinimumSize = new System.Drawing.Size(350, 0);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(350, 114);
            this.digits.TabIndex = 7;
            this.digits.Text = "00:00";
            this.digits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.BackgroundColor = System.Drawing.Color.White;
            this.timer.BorderColor = System.Drawing.Color.Black;
            this.timer.BorderRadius = 0;
            this.timer.BorderSize = 1;
            this.timer.FlatAppearance.BorderSize = 2;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer.ForeColor = System.Drawing.Color.Black;
            this.timer.Location = new System.Drawing.Point(12, 58);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(85, 40);
            this.timer.TabIndex = 9;
            this.timer.Text = "Temporizador";
            this.timer.TextColor = System.Drawing.Color.Black;
            this.timer.UseVisualStyleBackColor = false;
            this.timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // Reloj
            // 
            this.Reloj.BackColor = System.Drawing.Color.White;
            this.Reloj.BackgroundColor = System.Drawing.Color.White;
            this.Reloj.BorderColor = System.Drawing.Color.Black;
            this.Reloj.BorderRadius = 0;
            this.Reloj.BorderSize = 1;
            this.Reloj.FlatAppearance.BorderSize = 2;
            this.Reloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Reloj.ForeColor = System.Drawing.Color.Black;
            this.Reloj.Location = new System.Drawing.Point(12, 12);
            this.Reloj.Name = "Reloj";
            this.Reloj.Size = new System.Drawing.Size(85, 40);
            this.Reloj.TabIndex = 8;
            this.Reloj.Text = "Reloj";
            this.Reloj.TextColor = System.Drawing.Color.Black;
            this.Reloj.UseVisualStyleBackColor = false;
            this.Reloj.Click += new System.EventHandler(this.Reloj_Click);
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
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
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
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Green;
            this.Start.BackgroundColor = System.Drawing.Color.Green;
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
            // Crno
            // 
            this.Crno.BackColor = System.Drawing.Color.White;
            this.Crno.BackgroundColor = System.Drawing.Color.White;
            this.Crno.BorderColor = System.Drawing.Color.Black;
            this.Crno.BorderRadius = 0;
            this.Crno.BorderSize = 1;
            this.Crno.FlatAppearance.BorderSize = 2;
            this.Crno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crno.ForeColor = System.Drawing.Color.Black;
            this.Crno.Location = new System.Drawing.Point(12, 104);
            this.Crno.Name = "Crno";
            this.Crno.Size = new System.Drawing.Size(85, 40);
            this.Crno.TabIndex = 10;
            this.Crno.Text = "Temporizador";
            this.Crno.TextColor = System.Drawing.Color.Black;
            this.Crno.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Crno);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Reloj);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreacionBotones.BotonPersonalizado2 Start;
        private CreacionBotones.BotonPersonalizado2 Edit;
        private CreacionBotones.BotonPersonalizado2 Reset;
        private System.Windows.Forms.Label digits;
        private System.Windows.Forms.Timer timer1;
        private CreacionBotones.BotonPersonalizado2 Reloj;
        private CreacionBotones.BotonPersonalizado2 timer;
        private System.Windows.Forms.Timer timer2;
        private CreacionBotones.BotonPersonalizado2 Crno;
        private System.Windows.Forms.Timer timer3;
    }
}

