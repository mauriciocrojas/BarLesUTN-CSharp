using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class ControlStock : Form
    {
        Usuario tipoUsuario;


        public ControlStock(Usuario tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //this.rdbComida.Checked = true;

            this.txtNombreComida.Enabled = false;
            this.nudPrecioComida.Enabled = false;
            this.nudStockComida.Enabled = false;
            this.cmbSal.Enabled = false;
            this.txtNombreBebida.Enabled = false;
            this.nudPrecioBebida.Enabled = false;
            this.nudPesoBebida.Enabled = false;
            this.cmbTipoBebida.Enabled = false;
            this.nudStockBebida.Enabled = false;

            this.cmbSal.Items.Add("Sí");
            this.cmbSal.Items.Add("No");

            this.cmbTipoBebida.Items.Add("Alcoholicas");
            this.cmbTipoBebida.Items.Add("Gasificadas");
            this.cmbTipoBebida.Items.Add("Aguas");

            //this.cmbTipoBebida.DataSource = Enum.GetValues(typeof(Etipo));


            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            Bebida.HardcodearBebidas();
            Comida.HardcodearComidas();

            this.rchListaStock.Text = bebidas.MostrarStock() + comidas.MostrarStock();

            if (tipoUsuario is Administrador)
            {
                this.grpAdmin.Enabled = true;
                this.Text = "Menú de Administrador - Stock y agregado";

            }
            else
            {
                this.grpAdmin.Enabled = false;
                this.Text = "Menú de Empleado - Stock";

            }

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
                bool SiONo = this.cmbSal.SelectedIndex == 1 ? true : false;

                Comida.AgregarNuevaComida(this.txtNombreComida.Text, SiONo, this.nudStockComida.Value, this.nudPrecioComida.Value);
                this.rchListaStock.Text += bebida.MostrarStock() + comida.MostrarStock();
            }
            else if (this.rdbBebida.Checked)
            {
                ETipoBebida tipo;
                switch (cmbTipoBebida.Text)
                {
                    case "Alcoholicas":
                        tipo = ETipoBebida.Alcoholicas;
                        break;
                    case "Gasificadas":
                        tipo = ETipoBebida.Gasificadas;
                        break;
                    default:
                        tipo = ETipoBebida.Aguas;
                        break;

                }
                Bebida.AgregarNuevaBebida(this.txtNombreBebida.Text, this.nudPesoBebida.Value, tipo, this.nudStockBebida.Value, this.nudPrecioBebida.Value);
                this.rchListaStock.Text += bebida.MostrarStock() + comida.MostrarStock();

            }


        }

    }
}
