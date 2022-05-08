using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Login : Form
    {
        private bool btnSeCargoEmp = false;
        private bool btnSeCargoAdm = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Empleado.HardcodearEmpleados();
            Administrador.HardcodearAdministradores();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CheckearUsuario(this.txtUsuario.Text, this.txtClave.Text))
            {

                if (btnSeCargoEmp)
                {
                    Usuario usuario = CargarEmpleado();
                    Acceso acceso = new Acceso(usuario);
                    acceso.ShowDialog();
                }
                else if (btnSeCargoAdm)
                {
                    Usuario usuario = CargarAdministrador();
                    Acceso acceso = new Acceso(usuario);
                    acceso.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }


        public Usuario CargarEmpleado()
        {
            this.txtUsuario.Text = Empleado.listaEmpleados[0].user;
            this.txtClave.Text = Empleado.listaEmpleados[0].password;
            Usuario usuario = Empleado.listaEmpleados[0];
            return usuario;
        }

        public Usuario CargarAdministrador()
        {
            this.txtUsuario.Text = Administrador.listaAdministradores[0].user;
            this.txtClave.Text = Administrador.listaAdministradores[0].password;
            Usuario usuario = Administrador.listaAdministradores[0];
            return usuario;
        }

        private void btnCargarEmp_Click(object sender, EventArgs e)
        {
            CargarEmpleado();
            btnSeCargoEmp = true;
            btnSeCargoAdm = false;
        }

        private void btnCargarAdmin_Click(object sender, EventArgs e)
        {
            CargarAdministrador();
            btnSeCargoAdm = true;
            btnSeCargoEmp = false;
        }

        public bool CheckearUsuario(string usuario, string password)
        {
            if ((usuario == "aperez" && password == "arielsito") || (usuario == "lmessi" && password == "copaamerica"))
            {
                return true;
            }
            return false;
        }
    }
}
