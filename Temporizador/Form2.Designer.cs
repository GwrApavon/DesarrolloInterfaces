namespace Temporizador
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hrs = new System.Windows.Forms.Label();
            this.mnts = new System.Windows.Forms.Label();
            this.scds = new System.Windows.Forms.Label();
            this.Popup = new System.Windows.Forms.CheckBox();
            this.horas = new System.Windows.Forms.ComboBox();
            this.minutos = new System.Windows.Forms.ComboBox();
            this.segundos = new System.Windows.Forms.ComboBox();
            this.Restart = new System.Windows.Forms.CheckBox();
            this.Crono = new System.Windows.Forms.CheckBox();
            this.Cancel = new CreacionBotones.BotonPersonalizado2();
            this.Aceptar = new CreacionBotones.BotonPersonalizado2();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hrs
            // 
            this.hrs.AutoSize = true;
            this.hrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.hrs.Location = new System.Drawing.Point(52, 10);
            this.hrs.Name = "hrs";
            this.hrs.Size = new System.Drawing.Size(83, 25);
            this.hrs.TabIndex = 4;
            this.hrs.Text = "HORAS";
            // 
            // mnts
            // 
            this.mnts.AutoSize = true;
            this.mnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mnts.Location = new System.Drawing.Point(181, 10);
            this.mnts.Name = "mnts";
            this.mnts.Size = new System.Drawing.Size(105, 25);
            this.mnts.TabIndex = 5;
            this.mnts.Text = "MINUTOS";
            // 
            // scds
            // 
            this.scds.AutoSize = true;
            this.scds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scds.Location = new System.Drawing.Point(306, 10);
            this.scds.Name = "scds";
            this.scds.Size = new System.Drawing.Size(126, 25);
            this.scds.TabIndex = 6;
            this.scds.Text = "SEGUNDOS";
            // 
            // Popup
            // 
            this.Popup.AutoSize = true;
            this.Popup.Location = new System.Drawing.Point(322, 163);
            this.Popup.Name = "Popup";
            this.Popup.Size = new System.Drawing.Size(62, 17);
            this.Popup.TabIndex = 9;
            this.Popup.Text = "Pop Up";
            this.Popup.UseVisualStyleBackColor = true;
            // 
            // horas
            // 
            this.horas.FormattingEnabled = true;
            this.horas.Location = new System.Drawing.Point(33, 52);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(121, 21);
            this.horas.TabIndex = 10;
            // 
            // minutos
            // 
            this.minutos.FormattingEnabled = true;
            this.minutos.Location = new System.Drawing.Point(176, 52);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(121, 21);
            this.minutos.TabIndex = 11;
            // 
            // segundos
            // 
            this.segundos.FormattingEnabled = true;
            this.segundos.Location = new System.Drawing.Point(311, 52);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(121, 21);
            this.segundos.TabIndex = 12;
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Location = new System.Drawing.Point(322, 186);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(67, 17);
            this.Restart.TabIndex = 13;
            this.Restart.Text = "Reiniciar";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.CheckedChanged += new System.EventHandler(this.Restart_CheckedChanged);
            // 
            // Crono
            // 
            this.Crono.AutoSize = true;
            this.Crono.Location = new System.Drawing.Point(322, 209);
            this.Crono.Name = "Crono";
            this.Crono.Size = new System.Drawing.Size(139, 17);
            this.Crono.TabIndex = 14;
            this.Crono.Text = "Iniciar como cronómetro";
            this.Crono.UseVisualStyleBackColor = true;
            this.Crono.CheckedChanged += new System.EventHandler(this.Crono_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.BackgroundColor = System.Drawing.Color.White;
            this.Cancel.BorderColor = System.Drawing.Color.Black;
            this.Cancel.BorderRadius = 0;
            this.Cancel.BorderSize = 1;
            this.Cancel.FlatAppearance.BorderSize = 2;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(156, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 40);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "CANCELAR";
            this.Cancel.TextColor = System.Drawing.Color.Black;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.White;
            this.Aceptar.BackgroundColor = System.Drawing.Color.White;
            this.Aceptar.BorderColor = System.Drawing.Color.Black;
            this.Aceptar.BorderRadius = 0;
            this.Aceptar.BorderSize = 1;
            this.Aceptar.FlatAppearance.BorderSize = 2;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.ForeColor = System.Drawing.Color.Black;
            this.Aceptar.Location = new System.Drawing.Point(156, 163);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(150, 40);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "ACEPTAR";
            this.Aceptar.TextColor = System.Drawing.Color.Black;
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(128, 79);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 15;
            this.timePicker.Value = new System.DateTime(2023, 2, 8, 9, 40, 0, 0);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 272);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.Crono);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.Popup);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.scds);
            this.Controls.Add(this.mnts);
            this.Controls.Add(this.hrs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hrs;
        private System.Windows.Forms.Label mnts;
        private System.Windows.Forms.Label scds;
        private CreacionBotones.BotonPersonalizado2 Aceptar;
        private CreacionBotones.BotonPersonalizado2 Cancel;
        private System.Windows.Forms.CheckBox Popup;
        private System.Windows.Forms.ComboBox horas;
        private System.Windows.Forms.ComboBox minutos;
        private System.Windows.Forms.ComboBox segundos;
        private System.Windows.Forms.CheckBox Restart;
        private System.Windows.Forms.CheckBox Crono;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Timer timer1;
    }
}