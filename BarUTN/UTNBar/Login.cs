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
                System.Media.SystemSounds.Hand.Play();
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
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Función que cargara un empleado.
        /// </summary>
        /// <returns>Retorna un usuario tipo empleado</returns>
        public Usuario CargarEmpleado()
        {
            this.txtUsuario.Text = Empleado.listaEmpleados[0].user;
            this.txtClave.Text = Empleado.listaEmpleados[0].password;
            Usuario usuario = Empleado.listaEmpleados[0];
            return usuario;
        }

        /// <summary>
        /// Función que cargara un administrador.
        /// </summary>
        /// <returns>Retorna un usuario tipo administrador</returns>
        public Usuario CargarAdministrador()
        {
            this.txtUsuario.Text = Administrador.listaAdministradores[0].user;
            this.txtClave.Text = Administrador.listaAdministradores[0].password;
            Usuario usuario = Administrador.listaAdministradores[0];
            return usuario;
        }

        /// <summary>
        /// Botón que cargará los datos del empleado en los textbox correspondientes.
        /// </summary>
        private void btnCargarEmp_Click(object sender, EventArgs e)
        {
            CargarEmpleado();
            btnSeCargoEmp = true;
            btnSeCargoAdm = false;
        }

        /// <summary>
        /// Botón que cargará los datos del administrador en los textbox correspondientes.
        /// </summary>
        private void btnCargarAdmin_Click(object sender, EventArgs e)
        {
            CargarAdministrador();
            btnSeCargoAdm = true;
            btnSeCargoEmp = false;
        }

        /// <summary>
        /// Función que chequea si los usuarios ingresados son correctos
        /// </summary>
        /// <param name="usuario">Usuario que se pasará para chequear</param>
        /// <param name="password">Password que se pasará para chequear</param>
        /// <returns>Retorna true en caso correcto, sino false</returns>
        public bool CheckearUsuario(string usuario, string password)
        {
            if ((usuario == "aperez" && password == "arielsito") || (usuario == "lmessi" && password == "copaamerica"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Botón que cerrará toda la aplicación.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cuando se intente cerrar la app por completo, si se preguntará si está seguro.
        /// </summary>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();

            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
