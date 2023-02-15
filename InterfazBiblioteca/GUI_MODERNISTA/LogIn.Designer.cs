namespace GUI_MODERNISTA
{
    partial class LogIn
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
            this.loginText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.Label();
            this.pwdText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.accept = new CreacionBotones.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.loginText.Location = new System.Drawing.Point(547, 120);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(403, 110);
            this.loginText.TabIndex = 0;
            this.loginText.Text = "LOG IN";
            this.loginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(561, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(561, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 3;
            // 
            // userText
            // 
            this.userText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userText.AutoSize = true;
            this.userText.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.ForeColor = System.Drawing.Color.DarkGray;
            this.userText.Location = new System.Drawing.Point(556, 254);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(255, 27);
            this.userText.TabIndex = 4;
            this.userText.Text = "Nombre de Usuario:";
            // 
            // pwdText
            // 
            this.pwdText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwdText.AutoSize = true;
            this.pwdText.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdText.ForeColor = System.Drawing.Color.DarkGray;
            this.pwdText.Location = new System.Drawing.Point(556, 316);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(158, 27);
            this.pwdText.TabIndex = 5;
            this.pwdText.Text = "Contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 61);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca I.E.S Pablo Serrano";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GUI_MODERNISTA.Properties.Resources.biblioteca;
            this.pictureBox1.Location = new System.Drawing.Point(99, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // accept
            // 
            this.accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accept.BackColor = System.Drawing.Color.SeaGreen;
            this.accept.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.accept.BorderColor = System.Drawing.Color.Magenta;
            this.accept.BorderRadius = 20;
            this.accept.BorderSize = 0;
            this.accept.FlatAppearance.BorderSize = 0;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Location = new System.Drawing.Point(660, 417);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(185, 40);
            this.accept.TabIndex = 6;
            this.accept.Text = "ACEPTAR";
            this.accept.TextColor = System.Drawing.Color.White;
            this.accept.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.Label pwdText;
        private CreacionBotones.RJButton accept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}