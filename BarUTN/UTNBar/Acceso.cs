using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Acceso : Form
    {
        public string rol;
        public Acceso()
        {
            InitializeComponent();
        }
        public Acceso(Usuario usuario) : this()
        {
            this.rol = SetRol(usuario);

        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            if (rol == "Administrador")
            {
                this.buttonVerEmp.Enabled = true;
            }
            else
            {
                this.buttonVerEmp.Enabled = false;
            }
        }

        public string SetRol(Usuario usuario)
        {
            string rol;

            if (usuario is Administrador)
            {
                rol = "Administrador";
                this.Text = "Menú Administrador";


            }
            else
            {
                rol = "Empleado";
                this.Text = "Menú Empleado";

            }
            return rol;
        }

        //private void BebidasStrip_Click(object sender, EventArgs e)
        //{
        //    Stock stock = new Stock("Bebidas");
        //    stock.ShowDialog();
        //}



        private void buttonStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void buttonVerEmp_Click(object sender, EventArgs e)
        {
            Usuario empleado = new Empleado();
            Empleado.HardcodearEmpleados();
            MessageBox.Show(empleado.MostrarDatos());
        }

        //public void RenderItems()
        //{
        //    if (rol is Administrador)
        //    {

        //    }
        //}
    }
}
