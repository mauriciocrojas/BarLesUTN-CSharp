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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ubicacion));
            this.nudComidas = new System.Windows.Forms.NumericUpDown();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.nudBebidas = new System.Windows.Forms.NumericUpDown();
            this.lblComidas = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.chkComida = new System.Windows.Forms.CheckBox();
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.chkBebida = new System.Windows.Forms.CheckBox();
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.cmbMetodoDePago = new System.Windows.Forms.ComboBox();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudComidas
            // 
            this.nudComidas.Location = new System.Drawing.Point(241, 34);
            this.nudComidas.Name = "nudComidas";
            this.nudComidas.Size = new System.Drawing.Size(52, 23);
            this.nudComidas.TabIndex = 4;
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Location = new System.Drawing.Point(50, 89);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(48, 15);
            this.lblBebidas.TabIndex = 3;
            this.lblBebidas.Text = "Bebidas";
            // 
            // nudBebidas
            // 
            this.nudBebidas.Location = new System.Drawing.Point(239, 89);
            this.nudBebidas.Name = "nudBebidas";
            this.nudBebidas.Size = new System.Drawing.Size(54, 23);
            this.nudBebidas.TabIndex = 5;
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(50, 33);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(54, 15);
            this.lblComidas.TabIndex = 2;
            this.lblComidas.Text = "Comidas";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(104, 89);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 23);
            this.cmbBebidas.TabIndex = 1;
            // 
            // chkComida
            // 
            this.chkComida.AutoSize = true;
            this.chkComida.Location = new System.Drawing.Point(29, 33);
            this.chkComida.Name = "chkComida";
            this.chkComida.Size = new System.Drawing.Size(15, 14);
            this.chkComida.TabIndex = 7;
            this.chkComida.UseVisualStyleBackColor = true;
            this.chkComida.CheckedChanged += new System.EventHandler(this.chkComidaBebida_CheckedChanged);
            // 
            // cmbComidas
            // 
            this.cmbComidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(104, 33);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(121, 23);
            this.cmbComidas.TabIndex = 0;
            // 
            // chkBebida
            // 
            this.chkBebida.AutoSize = true;
            this.chkBebida.Location = new System.Drawing.Point(29, 89);
            this.chkBebida.Name = "chkBebida";
            this.chkBebida.Size = new System.Drawing.Size(15, 14);
            this.chkBebida.TabIndex = 8;
            this.chkBebida.UseVisualStyleBackColor = true;
            this.chkBebida.CheckedChanged += new System.EventHandler(this.chkComidaBebida_CheckedChanged);
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.Location = new System.Drawing.Point(189, 150);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Size = new System.Drawing.Size(104, 57);
            this.btnHacerPedido.TabIndex = 6;
            this.btnHacerPedido.Text = "Hacer pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            // 
            // cmbMetodoDePago
            // 
            this.cmbMetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoDePago.FormattingEnabled = true;
            this.cmbMetodoDePago.Location = new System.Drawing.Point(29, 168);
            this.cmbMetodoDePago.Name = "cmbMetodoDePago";
            this.cmbMetodoDePago.Size = new System.Drawing.Size(107, 23);
            this.cmbMetodoDePago.TabIndex = 9;
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.Location = new System.Drawing.Point(29, 150);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(95, 15);
            this.lblMetodoDePago.TabIndex = 10;
            this.lblMetodoDePago.Text = "Método de pago";
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(353, 281);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.cmbMetodoDePago);
            this.Controls.Add(this.btnHacerPedido);
            this.Controls.Add(this.chkBebida);
            this.Controls.Add(this.nudBebidas);
            this.Controls.Add(this.cmbComidas);
            this.Controls.Add(this.nudComidas);
            this.Controls.Add(this.chkComida);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.lblComidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ubicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudComidas;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.NumericUpDown nudBebidas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.CheckBox chkComida;
        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.CheckBox chkBebida;
        private System.Windows.Forms.Button btnHacerPedido;
        private System.Windows.Forms.ComboBox cmbMetodoDePago;
        private System.Windows.Forms.Label lblMetodoDePago;
    }
}