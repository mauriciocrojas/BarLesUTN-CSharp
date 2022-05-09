namespace UTNBar
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.nudPrecioComida = new System.Windows.Forms.NumericUpDown();
            this.rchListaStock = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockComida = new System.Windows.Forms.Label();
            this.lblStockBebida = new System.Windows.Forms.Label();
            this.lblTipoBebida = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbTipoBebida = new System.Windows.Forms.ComboBox();
            this.cmbSal = new System.Windows.Forms.ComboBox();
            this.nudStockBebida = new System.Windows.Forms.NumericUpDown();
            this.nudPesoBebida = new System.Windows.Forms.NumericUpDown();
            this.nudStockComida = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioBebida = new System.Windows.Forms.NumericUpDown();
            this.txtNombreBebida = new System.Windows.Forms.TextBox();
            this.txtNombreComida = new System.Windows.Forms.TextBox();
            this.rdbBebida = new System.Windows.Forms.RadioButton();
            this.rdbComida = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioComida)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioBebida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(365, 121);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(110, 23);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // nudPrecioComida
            // 
            this.nudPrecioComida.Location = new System.Drawing.Point(179, 40);
            this.nudPrecioComida.Name = "nudPrecioComida";
            this.nudPrecioComida.Size = new System.Drawing.Size(52, 23);
            this.nudPrecioComida.TabIndex = 5;
            // 
            // rchListaStock
            // 
            this.rchListaStock.Location = new System.Drawing.Point(12, 168);
            this.rchListaStock.Name = "rchListaStock";
            this.rchListaStock.ReadOnly = true;
            this.rchListaStock.Size = new System.Drawing.Size(481, 135);
            this.rchListaStock.TabIndex = 6;
            this.rchListaStock.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStockComida);
            this.groupBox1.Controls.Add(this.lblStockBebida);
            this.groupBox1.Controls.Add(this.lblTipoBebida);
            this.groupBox1.Controls.Add(this.lblPeso);
            this.groupBox1.Controls.Add(this.lblSal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cmbTipoBebida);
            this.groupBox1.Controls.Add(this.cmbSal);
            this.groupBox1.Controls.Add(this.nudStockBebida);
            this.groupBox1.Controls.Add(this.nudPesoBebida);
            this.groupBox1.Controls.Add(this.nudStockComida);
            this.groupBox1.Controls.Add(this.nudPrecioBebida);
            this.groupBox1.Controls.Add(this.nudPrecioComida);
            this.groupBox1.Controls.Add(this.txtNombreBebida);
            this.groupBox1.Controls.Add(this.txtNombreComida);
            this.groupBox1.Controls.Add(this.rdbBebida);
            this.groupBox1.Controls.Add(this.rdbComida);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar nuevo producto";
            // 
            // lblStockComida
            // 
            this.lblStockComida.AutoSize = true;
            this.lblStockComida.Location = new System.Drawing.Point(307, 22);
            this.lblStockComida.Name = "lblStockComida";
            this.lblStockComida.Size = new System.Drawing.Size(36, 15);
            this.lblStockComida.TabIndex = 21;
            this.lblStockComida.Text = "Stock";
            // 
            // lblStockBebida
            // 
            this.lblStockBebida.AutoSize = true;
            this.lblStockBebida.Location = new System.Drawing.Point(397, 73);
            this.lblStockBebida.Name = "lblStockBebida";
            this.lblStockBebida.Size = new System.Drawing.Size(36, 15);
            this.lblStockBebida.TabIndex = 20;
            this.lblStockBebida.Text = "Stock";
            // 
            // lblTipoBebida
            // 
            this.lblTipoBebida.AutoSize = true;
            this.lblTipoBebida.Location = new System.Drawing.Point(300, 73);
            this.lblTipoBebida.Name = "lblTipoBebida";
            this.lblTipoBebida.Size = new System.Drawing.Size(30, 15);
            this.lblTipoBebida.TabIndex = 19;
            this.lblTipoBebida.Text = "Tipo";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(237, 71);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(57, 15);
            this.lblPeso.TabIndex = 18;
            this.lblPeso.Text = "Peso (ml)";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(237, 22);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(62, 15);
            this.lblSal.TabIndex = 17;
            this.lblSal.Text = "¿Tiene sal?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(179, 22);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbTipoBebida
            // 
            this.cmbTipoBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBebida.FormattingEnabled = true;
            this.cmbTipoBebida.Location = new System.Drawing.Point(300, 90);
            this.cmbTipoBebida.Name = "cmbTipoBebida";
            this.cmbTipoBebida.Size = new System.Drawing.Size(91, 23);
            this.cmbTipoBebida.TabIndex = 14;
            // 
            // cmbSal
            // 
            this.cmbSal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSal.FormattingEnabled = true;
            this.cmbSal.Location = new System.Drawing.Point(237, 40);
            this.cmbSal.Name = "cmbSal";
            this.cmbSal.Size = new System.Drawing.Size(64, 23);
            this.cmbSal.TabIndex = 13;
            // 
            // nudStockBebida
            // 
            this.nudStockBebida.Location = new System.Drawing.Point(397, 91);
            this.nudStockBebida.Name = "nudStockBebida";
            this.nudStockBebida.Size = new System.Drawing.Size(52, 23);
            this.nudStockBebida.TabIndex = 12;
            // 
            // nudPesoBebida
            // 
            this.nudPesoBebida.Location = new System.Drawing.Point(237, 89);
            this.nudPesoBebida.Name = "nudPesoBebida";
            this.nudPesoBebida.Size = new System.Drawing.Size(57, 23);
            this.nudPesoBebida.TabIndex = 11;
            // 
            // nudStockComida
            // 
            this.nudStockComida.Location = new System.Drawing.Point(307, 40);
            this.nudStockComida.Name = "nudStockComida";
            this.nudStockComida.Size = new System.Drawing.Size(52, 23);
            this.nudStockComida.TabIndex = 10;
            // 
            // nudPrecioBebida
            // 
            this.nudPrecioBebida.Location = new System.Drawing.Point(179, 89);
            this.nudPrecioBebida.Name = "nudPrecioBebida";
            this.nudPrecioBebida.Size = new System.Drawing.Size(52, 23);
            this.nudPrecioBebida.TabIndex = 8;
            // 
            // txtNombreBebida
            // 
            this.txtNombreBebida.Location = new System.Drawing.Point(73, 89);
            this.txtNombreBebida.Name = "txtNombreBebida";
            this.txtNombreBebida.PlaceholderText = "Nombre bebida";
            this.txtNombreBebida.Size = new System.Drawing.Size(100, 23);
            this.txtNombreBebida.TabIndex = 7;
            // 
            // txtNombreComida
            // 
            this.txtNombreComida.Location = new System.Drawing.Point(73, 40);
            this.txtNombreComida.Name = "txtNombreComida";
            this.txtNombreComida.PlaceholderText = "Nombre plato";
            this.txtNombreComida.Size = new System.Drawing.Size(100, 23);
            this.txtNombreComida.TabIndex = 6;
            // 
            // rdbBebida
            // 
            this.rdbBebida.AutoSize = true;
            this.rdbBebida.Location = new System.Drawing.Point(6, 89);
            this.rdbBebida.Name = "rdbBebida";
            this.rdbBebida.Size = new System.Drawing.Size(61, 19);
            this.rdbBebida.TabIndex = 5;
            this.rdbBebida.Text = "Bebida";
            this.rdbBebida.UseVisualStyleBackColor = true;
            this.rdbBebida.CheckedChanged += new System.EventHandler(this.rdbBebida_CheckedChanged);
            // 
            // rdbComida
            // 
            this.rdbComida.AutoSize = true;
            this.rdbComida.Location = new System.Drawing.Point(6, 39);
            this.rdbComida.Name = "rdbComida";
            this.rdbComida.Size = new System.Drawing.Size(67, 19);
            this.rdbComida.TabIndex = 4;
            this.rdbComida.Text = "Comida";
            this.rdbComida.UseVisualStyleBackColor = true;
            this.rdbComida.Click += new System.EventHandler(this.rdbComida_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(505, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rchListaStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioComida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioBebida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown nudPrecioComida;
        private System.Windows.Forms.RichTextBox rchListaStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPrecioBebida;
        private System.Windows.Forms.TextBox txtNombreBebida;
        private System.Windows.Forms.TextBox txtNombreComida;
        private System.Windows.Forms.RadioButton rdbBebida;
        private System.Windows.Forms.RadioButton rdbComida;
        private System.Windows.Forms.NumericUpDown nudStockComida;
        private System.Windows.Forms.NumericUpDown nudStockBebida;
        private System.Windows.Forms.NumericUpDown nudPesoBebida;
        private System.Windows.Forms.ComboBox cmbSal;
        private System.Windows.Forms.Label lblStockComida;
        private System.Windows.Forms.Label lblStockBebida;
        private System.Windows.Forms.Label lblTipoBebida;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbTipoBebida;
    }
}