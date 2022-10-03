namespace Ejercicio_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.Tirada = new System.Windows.Forms.Button();
            this.Creditos = new System.Windows.Forms.Label();
            this.cantCred = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(67, 70);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(27, 23);
            this.num1.TabIndex = 0;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(184, 70);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(27, 23);
            this.num2.TabIndex = 1;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(308, 70);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(27, 23);
            this.num3.TabIndex = 2;
            this.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tirada
            // 
            this.Tirada.Location = new System.Drawing.Point(161, 148);
            this.Tirada.Name = "Tirada";
            this.Tirada.Size = new System.Drawing.Size(75, 23);
            this.Tirada.TabIndex = 3;
            this.Tirada.Text = "TIRAR";
            this.Tirada.UseVisualStyleBackColor = true;
            this.Tirada.Click += new System.EventHandler(this.button1_Click);
            // 
            // Creditos
            // 
            this.Creditos.AutoSize = true;
            this.Creditos.Location = new System.Drawing.Point(292, 9);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(62, 15);
            this.Creditos.TabIndex = 4;
            this.Creditos.Text = "CREDITOS:";
            this.Creditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Creditos.Click += new System.EventHandler(this.label1_Click);
            // 
            // cantCred
            // 
            this.cantCred.AutoSize = true;
            this.cantCred.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cantCred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantCred.Location = new System.Drawing.Point(355, 9);
            this.cantCred.Name = "cantCred";
            this.cantCred.Size = new System.Drawing.Size(21, 17);
            this.cantCred.TabIndex = 5;
            this.cantCred.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 484);
            this.Controls.Add(this.cantCred);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.Tirada);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox num1;
        private TextBox num2;
        private TextBox num3;
        private Button Tirada;
        private Label Creditos;
        private Label cantCred;
    }
}