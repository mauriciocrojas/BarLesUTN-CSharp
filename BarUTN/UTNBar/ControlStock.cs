using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class ControlStock : Form
    {
        Usuario tipoUsuario;

        /// <summary>
        /// Constructor que recibe un tipo de usuario para así mostrar y acceder a diferentes funcionalidades.
        /// </summary>
        /// <param name="tipoUsuario">Tipo de usuario que determinará diferentes funcionalidades</param>
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
            this.cmbSal.SelectedIndex = 1;

            this.cmbTipoBebida.Items.Add("Alcoholicas");
            this.cmbTipoBebida.Items.Add("Gasificadas");
            this.cmbTipoBebida.Items.Add("Aguas");
            this.cmbTipoBebida.SelectedIndex = 2;

            //this.cmbTipoBebida.DataSource = Enum.GetValues(typeof(Etipo));

            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            this.rchListaStock.Text = bebidas.MostrarStock() + comidas.MostrarStock();

            if (tipoUsuario is Administrador)
            {
                this.grpAdmin.Enabled = true;
                this.Text = "Menú de Administrador - Stock y agregado";
                this.BackColor = System.Drawing.Color.AliceBlue;
            }
            else
            {
                this.grpAdmin.Enabled = false;
                this.Text = "Menú de Empleado - Stock";
                this.BackColor = System.Drawing.Color.MistyRose;
            }
        }

        /// <summary>
        /// Si clickeamos en el radiobutton Comida, se habilitará para poder agregar una nueva. 
        /// Y se deshabilitará el poder agregar una bebida mientras esté con el check comida.
        /// </summary>
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

        /// <summary>
        /// Si clickeamos en el radiobutton Bebida, se habilitará para poder agregar una nueva. 
        /// Y se deshabilitará el poder agregar una comida mientras esté con el check bebida.
        /// </summary>
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

        /// <summary>
        /// Botón que agregará un nuevo producto.
        /// </summary>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarNuevoProducto();

        }

        /// <summary>
        /// Función que agregará un nuevo producto.
        /// </summary>
        public void AgregarNuevoProducto()
        {
            Comida comida = new Comida();
            Bebida bebida = new Bebida();
            if (this.rdbComida.Checked)
            {
                bool SiONo = this.cmbSal.SelectedIndex == 1 ? true : false;

                Comida.AgregarNuevaComida(this.txtNombreComida.Text, SiONo, this.nudStockComida.Value, this.nudPrecioComida.Value);
                this.rchListaStock.Text = bebida.MostrarStock() + comida.MostrarStock();
                MessageBox.Show("Se agregó nueva comida");
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
                this.rchListaStock.Text = bebida.MostrarStock() + comida.MostrarStock();
                MessageBox.Show("Se agregó nueva bebida");
            }
        }

        /// <summary>
        /// Botón que irá un pasó atrás en la aplicación.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Botón que cerrará toda la aplicación.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnActualizarStock(object sender, EventArgs e)
        //{
        //    Comida comidas = new Comida();
        //    Bebida bebidas = new Bebida();

        //    this.rchListaStock.Text = comidas.MostrarStock() + bebidas.MostrarStock();
        //}
    }
}
