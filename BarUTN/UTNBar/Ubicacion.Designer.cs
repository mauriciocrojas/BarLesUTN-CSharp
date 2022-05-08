namespace UTNBar
{
    partial class Ubicacion
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
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.nudComidas = new System.Windows.Forms.NumericUpDown();
            this.nudBebidas = new System.Windows.Forms.NumericUpDown();
            this.btnHacerPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbComidas
            // 
            this.cmbComidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(76, 45);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(121, 23);
            this.cmbComidas.TabIndex = 0;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(76, 101);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 23);
            this.cmbBebidas.TabIndex = 1;
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(22, 45);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(54, 15);
            this.lblComidas.TabIndex = 2;
            this.lblComidas.Text = "Comidas";
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Location = new System.Drawing.Point(22, 101);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(48, 15);
            this.lblBebidas.TabIndex = 3;
            this.lblBebidas.Text = "Bebidas";
            // 
            // nudComidas
            // 
            this.nudComidas.Location = new System.Drawing.Point(213, 46);
            this.nudComidas.Name = "nudComidas";
            this.nudComidas.Size = new System.Drawing.Size(52, 23);
            this.nudComidas.TabIndex = 4;
            // 
            // nudBebidas
            // 
            this.nudBebidas.Location = new System.Drawing.Point(211, 101);
            this.nudBebidas.Name = "nudBebidas";
            this.nudBebidas.Size = new System.Drawing.Size(54, 23);
            this.nudBebidas.TabIndex = 5;
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.Location = new System.Drawing.Point(161, 168);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Size = new System.Drawing.Size(104, 57);
            this.btnHacerPedido.TabIndex = 6;
            this.btnHacerPedido.Text = "Hacer pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 270);
            this.Controls.Add(this.btnHacerPedido);
            this.Controls.Add(this.nudBebidas);
            this.Controls.Add(this.nudComidas);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.cmbComidas);
            this.Name = "Ubicacion";
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.NumericUpDown nudComidas;
        private System.Windows.Forms.NumericUpDown nudBebidas;
        private System.Windows.Forms.Button btnHacerPedido;
    }
}