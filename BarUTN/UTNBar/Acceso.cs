using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Acceso : Form
    {
        public Usuario tipoUsuario;

        public Acceso(Usuario usuario)
        {
            InitializeComponent();
            this.tipoUsuario = SetTipoUsuario(usuario);

        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            if (tipoUsuario is Administrador)
            {
                this.btnVerEmp.Enabled = true;
            }
            else
            {
                this.btnVerEmp.Enabled = false;
                this.btnAgregarProducto.Enabled = false;
            }
        }

        public Usuario SetTipoUsuario(Usuario usuario)
        {

            if (usuario is Administrador)
            {

                this.Text = "Menú Administrador";
                return usuario;


            }
            else
            {
                this.Text = "Menú Empleado";
                return usuario;

            }
        }

        private void btnVerEmp_Click(object sender, EventArgs e)
        {
            Usuario empleado = new Empleado();
            Empleado.HardcodearEmpleados();
            MessageBox.Show(empleado.MostrarDatos());
            
        }


        private void btnMesa1_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacionForm = new Ubicacion(1);
            ubicacionForm.ShowDialog(); 
        }

        private void btnBarra16_Click(object sender, EventArgs e)
        {
                Ubicacion ubicacionForm = new Ubicacion(16);
                ubicacionForm.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto stock = new AgregarProducto("Menú de stock y agregado");
            stock.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockProductos stockProductos = new StockProductos();
            stockProductos.ShowDialog();
        }
    }
}
