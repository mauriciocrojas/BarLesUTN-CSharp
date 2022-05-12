using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Acceso : Form
    {
        public Usuario tipoUsuario;
        Dictionary<int, Button> botones;

        public Acceso(Usuario usuario)
        {
            InitializeComponent();
            this.tipoUsuario = SetTipoUsuario(usuario);
            botones = new Dictionary<int, Button>();

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
            }

            botones.Add(1, this.btnMesa1);
            botones.Add(2, this.btnMesa2);
            botones.Add(3, this.btnMesa3);
            botones.Add(4, this.btnMesa4);
            botones.Add(5, this.btnMesa5);
            botones.Add(6, this.btnMesa6);
            botones.Add(7, this.btnMesa7);
            botones.Add(8, this.btnMesa8);
            botones.Add(9, this.btnMesa9);
            botones.Add(10, this.btnMesa10);
            botones.Add(11, this.btnMesa11);
            botones.Add(12, this.btnMesa12);
            botones.Add(13, this.btnMesa13);
            botones.Add(14, this.btnMesa14);
            botones.Add(15, this.btnMesa15);
            botones.Add(16, this.btnBarra16);
            botones.Add(17, this.btnBarra17);
            botones.Add(18, this.btnBarra18);
            botones.Add(19, this.btnBarra19);
            botones.Add(20, this.btnBarra20);
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


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (tipoUsuario is Administrador)
            {
                ControlStock stock = new ControlStock(tipoUsuario);
                stock.ShowDialog();


            }
            else
            {
                ControlStock stock = new ControlStock(tipoUsuario);
                stock.ShowDialog();

            }
        }

        private void btnUbicacion(object sender, EventArgs e)
        {

            Button boton = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == boton)
                {
                    Ubicacion ubicacionForm = new Ubicacion(item.Key);
                    ubicacionForm.ShowDialog();
                }
            }
        }
    }
}
