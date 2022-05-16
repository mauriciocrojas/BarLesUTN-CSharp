namespace UTNBar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLesUTN = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCargarAdmin = new System.Windows.Forms.Button();
            this.btnCargarEmp = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLesUTN
            // 
            this.lblLesUTN.AutoSize = true;
            this.lblLesUTN.BackColor = System.Drawing.Color.MistyRose;
            this.lblLesUTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLesUTN.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLesUTN.Location = new System.Drawing.Point(158, 19);
            this.lblLesUTN.Name = "lblLesUTN";
            this.lblLesUTN.Size = new System.Drawing.Size(140, 39);
            this.lblLesUTN.TabIndex = 0;
            this.lblLesUTN.Text = "Les UTN";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(136, 120);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(136, 208);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(36, 15);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 138);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(136, 226);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(182, 23);
            this.txtClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(180, 277);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCargarAdmin
            // 
            this.btnCargarAdmin.Location = new System.Drawing.Point(335, 324);
            this.btnCargarAdmin.Name = "btnCargarAdmin";
            this.btnCargarAdmin.Size = new System.Drawing.Size(112, 23);
            this.btnCargarAdmin.TabIndex = 7;
            this.btnCargarAdmin.Text = "Cargar Admin";
            this.btnCargarAdmin.UseVisualStyleBackColor = true;
            this.btnCargarAdmin.Click += new System.EventHandler(this.btnCargarAdmin_Click);
            // 
            // btnCargarEmp
            // 
            this.btnCargarEmp.Location = new System.Drawing.Point(335, 348);
            this.btnCargarEmp.Name = "btnCargarEmp";
            this.btnCargarEmp.Size = new System.Drawing.Size(112, 23);
            this.btnCargarEmp.TabIndex = 8;
            this.btnCargarEmp.Text = "Cargar Empleado";
            this.btnCargarEmp.UseVisualStyleBackColor = true;
            this.btnCargarEmp.Click += new System.EventHandler(this.btnCargarEmp_Click);
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.BackColor = System.Drawing.Color.MistyRose;
            this.lblBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBar.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblBar.Location = new System.Drawing.Point(192, 58);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(66, 39);
            this.lblBar.TabIndex = 9;
            this.lblBar.Text = "Bar";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(16, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 38);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(459, 383);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.btnCargarEmp);
            this.Controls.Add(this.btnCargarAdmin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLesUTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLesUTN;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCargarAdmin;
        private System.Windows.Forms.Button btnCargarEmp;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Button btnSalir;
    }
}
