namespace GUI_MODERNISTA
{
    partial class MainApp
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Loan = new System.Windows.Forms.Button();
            this.Member = new System.Windows.Forms.Button();
            this.Book = new System.Windows.Forms.Button();
            this.UserAcc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.Loan);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.Member);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.Book);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.UserAcc);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 4;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelForms.Controls.Add(this.pictureBox2);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(220, 38);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1080, 612);
            this.panelForms.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_MODERNISTA.Properties.Resources.biblioteca;
            this.pictureBox2.Location = new System.Drawing.Point(247, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(669, 391);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Loan
            // 
            this.Loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Loan.FlatAppearance.BorderSize = 0;
            this.Loan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loan.ForeColor = System.Drawing.Color.White;
            this.Loan.Image = global::GUI_MODERNISTA.Properties.Resources.prestamo30px;
            this.Loan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loan.Location = new System.Drawing.Point(3, 248);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(217, 32);
            this.Loan.TabIndex = 7;
            this.Loan.Text = "Prestamos";
            this.Loan.UseVisualStyleBackColor = false;
            this.Loan.Click += new System.EventHandler(this.Loan_Click);
            // 
            // Member
            // 
            this.Member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Member.FlatAppearance.BorderSize = 0;
            this.Member.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Member.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member.ForeColor = System.Drawing.Color.White;
            this.Member.Image = global::GUI_MODERNISTA.Properties.Resources.socios30px;
            this.Member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Member.Location = new System.Drawing.Point(3, 210);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(217, 32);
            this.Member.TabIndex = 5;
            this.Member.Text = "Socios";
            this.Member.UseVisualStyleBackColor = false;
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.ForeColor = System.Drawing.Color.White;
            this.Book.Image = global::GUI_MODERNISTA.Properties.Resources.libro30px;
            this.Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Book.Location = new System.Drawing.Point(3, 172);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(217, 32);
            this.Book.TabIndex = 3;
            this.Book.Text = "Libros";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // UserAcc
            // 
            this.UserAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.UserAcc.FlatAppearance.BorderSize = 0;
            this.UserAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.UserAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAcc.ForeColor = System.Drawing.Color.White;
            this.UserAcc.Image = global::GUI_MODERNISTA.Properties.Resources._30px;
            this.UserAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserAcc.Location = new System.Drawing.Point(3, 134);
            this.UserAcc.Name = "UserAcc";
            this.UserAcc.Size = new System.Drawing.Size(217, 32);
            this.UserAcc.TabIndex = 1;
            this.UserAcc.Text = "Cuenta";
            this.UserAcc.UseVisualStyleBackColor = false;
            this.UserAcc.Click += new System.EventHandler(this.UserAcc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_MODERNISTA.Properties.Resources.fp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1221, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1180, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1221, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1262, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Loan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Member;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

