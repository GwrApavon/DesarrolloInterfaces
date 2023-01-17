namespace SimonDice
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
            this.button_0 = new System.Windows.Forms.PictureBox();
            this.button_1 = new System.Windows.Forms.PictureBox();
            this.button_2 = new System.Windows.Forms.PictureBox();
            this.button_3 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.button_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_0
            // 
            this.button_0.Image = global::SimonDice.Properties.Resources.SimonDiceBlue;
            this.button_0.Location = new System.Drawing.Point(197, 12);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(256, 264);
            this.button_0.TabIndex = 0;
            this.button_0.TabStop = false;
            this.button_0.Click += new System.EventHandler(this.Button_Click);
            this.button_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bluebutton_MouseDown);
            this.button_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bluebutton_MouseUp);
            // 
            // button_1
            // 
            this.button_1.Image = global::SimonDice.Properties.Resources.SimonDiceGreen;
            this.button_1.Location = new System.Drawing.Point(459, 12);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(257, 264);
            this.button_1.TabIndex = 1;
            this.button_1.TabStop = false;
            this.button_1.Click += new System.EventHandler(this.Button_Click);
            this.button_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Greenbutton_MouseDown);
            this.button_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Greenbutton_MouseUp);
            // 
            // button_2
            // 
            this.button_2.Image = global::SimonDice.Properties.Resources.SimonDiceRed;
            this.button_2.Location = new System.Drawing.Point(197, 282);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(256, 257);
            this.button_2.TabIndex = 2;
            this.button_2.TabStop = false;
            this.button_2.Click += new System.EventHandler(this.Button_Click);
            this.button_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Redbutton_MouseDown);
            this.button_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Redbutton_MouseUp);
            // 
            // button_3
            // 
            this.button_3.Image = global::SimonDice.Properties.Resources.SimonDiceYellow;
            this.button_3.Location = new System.Drawing.Point(459, 282);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(258, 257);
            this.button_3.TabIndex = 3;
            this.button_3.TabStop = false;
            this.button_3.Click += new System.EventHandler(this.Button_Click);
            this.button_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yellowbutton_MouseDown);
            this.button_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Yellowbutton_MouseUp);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.score.Location = new System.Drawing.Point(13, 13);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(75, 25);
            this.score.TabIndex = 4;
            this.score.Text = "Score: ";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startButton.Location = new System.Drawing.Point(18, 559);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(878, 37);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 608);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.button_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox button_0;
        private System.Windows.Forms.PictureBox button_1;
        private System.Windows.Forms.PictureBox button_2;
        private System.Windows.Forms.PictureBox button_3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button startButton;
    }
}

