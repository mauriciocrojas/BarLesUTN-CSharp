﻿using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class AgregarProducto : Form
    {
        private string nombreVentanaStock;

        public AgregarProducto(string nombreVentanaStock)
        {
            InitializeComponent();
            this.nombreVentanaStock = nombreVentanaStock;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //this.rdbComida.Checked = true;

            this.cmbSal.Items.Add("Sí");
            this.cmbSal.Items.Add("No");

            this.cmbTipoBebida.Items.Add("Alcoholicas");
            this.cmbTipoBebida.Items.Add("Gasificadas");
            this.cmbTipoBebida.Items.Add("Aguas");

            //this.cmbTipoBebida.DataSource = Enum.GetValues(typeof(Etipo));


            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            bebidas.HardcodearBebidas();
            comidas.HardcodearComidas();

            this.Text = this.nombreVentanaStock;
            this.rchListaStock.Text = bebidas.MostrarStock() + comidas.MostrarStock();


        }

        private void rdbComida_Click(object sender, EventArgs e)
        {
            this.txtNombreComida.Enabled = true;
            this.nudPrecioComida.Enabled = true;
            this.nudStockComida.Enabled = true;
            this.cmbSal.Enabled = true;
            this.txtNombreBebida.Enabled = false;
            this.nudPrecioBebida.Enabled = false;
            this.nudPesoBebida.Enabled = false;
            this.cmbTipoBebida.Enabled = false;
            this.nudStockBebida.Enabled = false;

            this.rdbBebida.Checked = false;
        }

        private void rdbBebida_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNombreComida.Enabled = false;
            this.nudPrecioComida.Enabled = false;
            this.nudStockComida.Enabled = false;
            this.cmbSal.Enabled = false;
            this.txtNombreBebida.Enabled = true;
            this.nudPrecioBebida.Enabled = true;
            this.nudPesoBebida.Enabled = true;
            this.cmbTipoBebida.Enabled = true;
            this.nudStockBebida.Enabled = true;

            this.rdbComida.Checked = false;

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarNuevoProducto();
            MessageBox.Show("Se agregó nuevo producto");


        }

        public void AgregarNuevoProducto()
        {
            Comida comida = new Comida();
            Bebida bebida = new Bebida();
            if (this.rdbComida.Checked)
            {
                bool SiONo = this.cmbSal.SelectedIndex == 1? true : false;

                Comida.AgregarNuevaComida(this.txtNombreComida.Text, SiONo, this.nudStockComida.Value, this.nudPrecioComida.Value);
                this.rchListaStock.Text += bebida.MostrarStock() + comida.MostrarStock();
            }
            else if (this.rdbBebida.Checked)
            {
                Etipo tipo;
                switch (cmbTipoBebida.Text)
                {
                    case "Alhocolicas":
                        tipo = Etipo.Alcoholicas;
                        break;
                    case "Gasificadas":
                        tipo = Etipo.Gasificadas;
                        break;
                    default:
                        tipo = Etipo.Aguas;
                        break;

                }
                Bebida.AgregarNuevaBebida(this.txtNombreBebida.Text, this.nudPesoBebida.Value, tipo, this.nudStockBebida.Value, this.nudPrecioBebida.Value);
                this.rchListaStock.Text += bebida.MostrarStock() + comida.MostrarStock();

            }


        }

    }
}
