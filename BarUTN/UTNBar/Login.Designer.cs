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
            this.lblBar = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnOlvideClave = new System.Windows.Forms.Button();
            this.btnCargarAdmin = new System.Windows.Forms.Button();
            this.btnCargarEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Location = new System.Drawing.Point(200, 31);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(71, 15);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "Bar LES UTN";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(76, 97);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(76, 197);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(36, 15);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(76, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(81, 222);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(177, 23);
            this.txtClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(76, 295);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnOlvideClave
            // 
            this.btnOlvideClave.Location = new System.Drawing.Point(174, 295);
            this.btnOlvideClave.Name = "btnOlvideClave";
            this.btnOlvideClave.Size = new System.Drawing.Size(84, 42);
            this.btnOlvideClave.TabIndex = 6;
            this.btnOlvideClave.Text = "Olvidé contraseña";
            this.btnOlvideClave.UseVisualStyleBackColor = true;
            // 
            // btnCargarAdmin
            // 
            this.btnCargarAdmin.Location = new System.Drawing.Point(314, 222);
            this.btnCargarAdmin.Name = "btnCargarAdmin";
            this.btnCargarAdmin.Size = new System.Drawing.Size(73, 41);
            this.btnCargarAdmin.TabIndex = 7;
            this.btnCargarAdmin.Text = "Cargar Admin";
            this.btnCargarAdmin.UseVisualStyleBackColor = true;
            this.btnCargarAdmin.Click += new System.EventHandler(this.btnCargarAdmin_Click);
            // 
            // btnCargarEmp
            // 
            this.btnCargarEmp.Location = new System.Drawing.Point(314, 295);
            this.btnCargarEmp.Name = "btnCargarEmp";
            this.btnCargarEmp.Size = new System.Drawing.Size(73, 41);
            this.btnCargarEmp.TabIndex = 8;
            this.btnCargarEmp.Text = "Cargar Empleado";
            this.btnCargarEmp.UseVisualStyleBackColor = true;
            this.btnCargarEmp.Click += new System.EventHandler(this.btnCargarEmp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.btnCargarEmp);
            this.Controls.Add(this.btnCargarAdmin);
            this.Controls.Add(this.btnOlvideClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOlvideClave;
        private System.Windows.Forms.Button btnCargarAdmin;
        private System.Windows.Forms.Button btnCargarEmp;
    }
}
