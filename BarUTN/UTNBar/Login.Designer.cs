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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsu = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnOlvidar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Location = new System.Drawing.Point(169, 29);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(71, 15);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "Bar LES UTN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // textUsu
            // 
            this.textUsu.Location = new System.Drawing.Point(76, 115);
            this.textUsu.Name = "textUsu";
            this.textUsu.Size = new System.Drawing.Size(182, 23);
            this.textUsu.TabIndex = 3;
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(81, 222);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(177, 23);
            this.textClave.TabIndex = 4;
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
            // btnOlvidar
            // 
            this.btnOlvidar.Location = new System.Drawing.Point(174, 295);
            this.btnOlvidar.Name = "btnOlvidar";
            this.btnOlvidar.Size = new System.Drawing.Size(84, 42);
            this.btnOlvidar.TabIndex = 6;
            this.btnOlvidar.Text = "Olvidé contraseña";
            this.btnOlvidar.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(314, 222);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(73, 41);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Cargar Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(314, 295);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(73, 41);
            this.btnEmp.TabIndex = 8;
            this.btnEmp.Text = "Cargar Empleado";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 377);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOlvidar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsu;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOlvidar;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmp;
    }
}
