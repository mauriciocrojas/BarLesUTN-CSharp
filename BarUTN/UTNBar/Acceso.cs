using Entidades;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using System.Drawing;

namespace UTNBar
{
    public partial class Acceso : Form
    {
        public Usuario tipoUsuario;
        Dictionary<int, Button> botonesMesas;
        Dictionary<int, Button> botonesBarra;
        Dictionary<int, bool> mesasDisponibles;
        Dictionary<int, bool> barraDisponible;


        public Acceso(Usuario usuario)
        {
            InitializeComponent();
            botonesMesas = new Dictionary<int, Button>();
            botonesBarra = new Dictionary<int, Button>();
            HardcodearMesas();
            HarcodearBarra();
            this.tipoUsuario = SetTipoUsuario(usuario);

        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            DisponibilidadDeMesas();
            DisponibilidadDeBarra();

            if (tipoUsuario is Administrador)
            {
                this.btnVerEmp.Enabled = true;
                this.BackColor = System.Drawing.Color.AliceBlue;
            }
            else
            {
                this.btnVerEmp.Enabled = false;
                this.BackColor = System.Drawing.Color.MistyRose;
            }


        }

        private void HardcodearMesas()
        {

            botonesMesas.Add(1, this.btnMesa1);
            botonesMesas.Add(2, this.btnMesa2);
            botonesMesas.Add(3, this.btnMesa3);
            botonesMesas.Add(4, this.btnMesa4);
            botonesMesas.Add(5, this.btnMesa5);
            botonesMesas.Add(6, this.btnMesa6);
            botonesMesas.Add(7, this.btnMesa7);
            botonesMesas.Add(8, this.btnMesa8);
            botonesMesas.Add(9, this.btnMesa9);
            botonesMesas.Add(10, this.btnMesa10);
            botonesMesas.Add(11, this.btnMesa11);
            botonesMesas.Add(12, this.btnMesa12);
            botonesMesas.Add(13, this.btnMesa13);
            botonesMesas.Add(14, this.btnMesa14);
            botonesMesas.Add(15, this.btnMesa15);
        }

        private void HarcodearBarra() {
            botonesBarra.Add(1, this.btnBarra16);
            botonesBarra.Add(2, this.btnBarra17);
            botonesBarra.Add(3, this.btnBarra18);
            botonesBarra.Add(4, this.btnBarra19);
            botonesBarra.Add(5, this.btnBarra20);
        
        }

        private void DisponibilidadDeMesas()
        {
            mesasDisponibles = Mesa.MesasOcupadas();

            foreach (KeyValuePair<int, bool> mesa in mesasDisponibles)
            {
                if (mesa.Value)
                    botonesMesas[mesa.Key].BackColor = Color.Peru; //libres
                else
                    botonesMesas[mesa.Key].BackColor = Color.Beige; //ocupadas
            }
        }

        /// <summary>
        /// Función que analiza si el valor que devuelve barraDisponible = Barra.BarraOcupada, es null o no. 
        /// Si es null, significa que la mesa no tiene cliente, por ende está libre.
        /// Color Peru = libre / Color Beige = Ocupada
        /// </summary>
        private void DisponibilidadDeBarra()
        {
            barraDisponible = Barra.BarraOcupada();

            foreach (KeyValuePair<int, bool> barra in barraDisponible)
            {
                if (barra.Value)
                    botonesBarra[barra.Key].BackColor = Color.Peru;
                else
                    botonesBarra[barra.Key].BackColor = Color.Beige;
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
            MessageBox.Show(empleado.MostrarDatos(), "Empleados Les UTN Bar");

        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            //if (tipoUsuario is Administrador)
            //{
            //    ControlStock stock = new ControlStock(tipoUsuario);
            //    stock.ShowDialog();


            //}
            //else
            //{
            //    ControlStock stock = new ControlStock(tipoUsuario);
            //    stock.ShowDialog();

            //}

            ControlStock stock = new ControlStock(tipoUsuario);
            stock.ShowDialog();

        }

        private void btnUbicacion(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\maurojas\Documents\Alumni\PPLB\Sonidos\bipmesa.wav");
            player.Play();


            Button boton = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botonesMesas)
            {
                if (item.Value == boton)
                {
                    Ubicacion ubicacionForm = new Ubicacion(item.Key, tipoUsuario);
                    ubicacionForm.ShowDialog();
                }
            }
            foreach (KeyValuePair<int, Button> item in botonesBarra)
            {
                if (item.Value == boton)
                {
                    Ubicacion ubicacionForm = new Ubicacion(item.Key + 15, tipoUsuario);
                    ubicacionForm.ShowDialog();
                }
            }
        }

        private void btnUsuarioLogeado_Click(object sender, EventArgs e)
        {
            if (tipoUsuario is Administrador)
            {

                //string cadena = $"Usuario logueado: {Administrador.listaAdministradores[0].user}, {Administrador.listaAdministradores[0].nombre} {Administrador.listaAdministradores[0].apellido}";
                string cadena = Administrador.listaAdministradores[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo Administrador");
            }
            else
            {
                //string cadena = $"Usuario logueado: {Empleado.listaEmpleados[0].user}, {Empleado.listaEmpleados[0].nombre} {Empleado.listaEmpleados[0].apellido}";
                string cadena = Empleado.listaEmpleados[0].MostrarDato();
                MessageBox.Show(cadena, "Usuario logueado tipo Empleado");
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
