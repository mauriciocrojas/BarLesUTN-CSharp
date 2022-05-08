using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UTNBar
{
    public partial class Login : Form
    {
        private bool btnEmpl = false;
        private bool btnAdm = false;
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
            //Usuario usuario = ComprobarInstancia();
            if (btnEmpl)
            {
            Usuario usuario = CargarEmpleado();
            Acceso acceso = new Acceso(usuario);
            acceso.ShowDialog();
            }
            else if (btnAdm)
            {
                Usuario usuario = CargarAdministrador();
                Acceso acceso = new Acceso(usuario);
                acceso.ShowDialog();
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            CargarEmpleado();
            btnEmpl = true;

        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            CargarAdministrador();
            btnAdm = true;
        }

        public Usuario CargarEmpleado()
        {
            this.textUsu.Text = Empleado.listaEmpleados[0].user;
            this.textClave.Text = Empleado.listaEmpleados[0].password;
            Usuario usuario = Empleado.listaEmpleados[0];
            return usuario;
        }

        public Usuario CargarAdministrador()
        {
            this.textUsu.Text = Administrador.listaAdministradores[0].user;
            this.textClave.Text = Administrador.listaAdministradores[0].password;
            Usuario usuario = Administrador.listaAdministradores[0];
            return usuario;
        }

        //public Usuario ComprobarInstancia(Usuario usuario)
        //{
        //    if (usuario is Administrador)
        //    {
        //        return usuario;
        //    }
        //    else if (usuario is Empleado)
        //    {
        //        return usuario;
        //    }
        //    return null;
        //}

    }
}
