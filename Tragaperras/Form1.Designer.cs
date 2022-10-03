namespace Tragaperras
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
            this.roll = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.Cred = new System.Windows.Forms.Label();
            this.creditos = new System.Windows.Forms.Label();
            this.Acreditos = new System.Windows.Forms.Button();
            this.premio1 = new System.Windows.Forms.Label();
            this.premio2 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(112, 188);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(94, 23);
            this.roll.TabIndex = 0;
            this.roll.Text = "ROLL";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.SystemColors.Control;
            this.num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num1.Location = new System.Drawing.Point(90, 86);
            this.num1.MinimumSize = new System.Drawing.Size(20, 35);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(25, 35);
            this.num1.TabIndex = 2;
            this.num1.Text = "0";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.SystemColors.Control;
            this.num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num2.Location = new System.Drawing.Point(147, 86);
            this.num2.MinimumSize = new System.Drawing.Size(20, 35);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(25, 35);
            this.num2.TabIndex = 3;
            this.num2.Text = "0";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.SystemColors.Control;
            this.num3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.num3.Location = new System.Drawing.Point(202, 86);
            this.num3.MinimumSize = new System.Drawing.Size(20, 35);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(25, 35);
            this.num3.TabIndex = 4;
            this.num3.Text = "0";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cred
            // 
            this.Cred.AutoSize = true;
            this.Cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cred.Location = new System.Drawing.Point(199, 16);
            this.Cred.Name = "Cred";
            this.Cred.Size = new System.Drawing.Size(68, 17);
            this.Cred.TabIndex = 5;
            this.Cred.Text = "Creditos: ";
            this.Cred.Click += new System.EventHandler(this.label3_Click);
            // 
            // creditos
            // 
            this.creditos.AutoSize = true;
            this.creditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.creditos.Location = new System.Drawing.Point(263, 16);
            this.creditos.MinimumSize = new System.Drawing.Size(10, 10);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(26, 19);
            this.creditos.TabIndex = 6;
            this.creditos.Text = "50";
            // 
            // Acreditos
            // 
            this.Acreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Acreditos.Location = new System.Drawing.Point(90, 338);
            this.Acreditos.Name = "Acreditos";
            this.Acreditos.Size = new System.Drawing.Size(137, 26);
            this.Acreditos.TabIndex = 7;
            this.Acreditos.Text = "Añadir Creditos";
            this.Acreditos.UseVisualStyleBackColor = true;
            this.Acreditos.Click += new System.EventHandler(this.button2_Click);
            // 
            // premio1
            // 
            this.premio1.AutoSize = true;
            this.premio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.premio1.ForeColor = System.Drawing.Color.Red;
            this.premio1.Location = new System.Drawing.Point(87, 243);
            this.premio1.MinimumSize = new System.Drawing.Size(150, 10);
            this.premio1.Name = "premio1";
            this.premio1.Size = new System.Drawing.Size(150, 17);
            this.premio1.TabIndex = 8;
            this.premio1.Text = "Ha ganado 20€";
            this.premio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.premio1.Visible = false;
            // 
            // premio2
            // 
            this.premio2.AutoSize = true;
            this.premio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.premio2.ForeColor = System.Drawing.Color.Red;
            this.premio2.Location = new System.Drawing.Point(87, 284);
            this.premio2.MinimumSize = new System.Drawing.Size(150, 10);
            this.premio2.Name = "premio2";
            this.premio2.Size = new System.Drawing.Size(150, 17);
            this.premio2.TabIndex = 9;
            this.premio2.Text = "Ha ganado 5€";
            this.premio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.premio2.Visible = false;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(34, 381);
            this.warning.MinimumSize = new System.Drawing.Size(150, 10);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(255, 17);
            this.warning.TabIndex = 10;
            this.warning.Text = "AÑADE CREDITOS PARA CONTINUAR";
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 407);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.premio2);
            this.Controls.Add(this.premio1);
            this.Controls.Add(this.Acreditos);
            this.Controls.Add(this.creditos);
            this.Controls.Add(this.Cred);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label Cred;
        private System.Windows.Forms.Label creditos;
        private System.Windows.Forms.Button Acreditos;
        private System.Windows.Forms.Label premio1;
        private System.Windows.Forms.Label premio2;
        private System.Windows.Forms.Label warning;
    }
}


