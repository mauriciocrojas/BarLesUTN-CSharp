using Entidades;
using System;
using System.Media;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Ubicacion : Form
    {
        Usuario tipoUsuario;
        Pedido tipoUbicacion;
        public int numeroUbicacion;

        /// <summary>
        /// Constructor que recibe una ubicacion y un tipo de usuario.
        /// </summary>
        /// <param name="ubicacion">Parámaetro que determinará la ubicación en el bar</param>
        /// <param name="tipoUsuario">Usuario que definirá cómo se mostrarará el formulario de ubicación</param>
        public Ubicacion(int ubicacion, Usuario tipoUsuario)
        {
            InitializeComponent();
            this.numeroUbicacion = SiEsMesaOBarra(ubicacion);
            this.tipoUsuario = tipoUsuario;
        }

        private void Ubicacion_Load(object sender, EventArgs e)
        {

            if (tipoUsuario is Administrador)
            {
                this.BackColor = System.Drawing.Color.AliceBlue;
            }
            else
            {
                this.BackColor = System.Drawing.Color.MistyRose;
            }
            //this.cmbComidas.Items.Add("Verduras al vapor");
            //this.cmbComidas.Items.Add("Pastel de choclo");
            //this.cmbComidas.Items.Add("Merluza con puré");
            //this.cmbBebidas.Items.Add("Gin Tonic");
            //this.cmbBebidas.Items.Add("Seven Up");
            //this.cmbBebidas.Items.Add("Agua sin gas");

            this.cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoDePago));



            foreach (Comida comida in Comida.listaComidas)
            {
                this.cmbComidas.Items.Add(comida.nombre);
            }
            foreach (Bebida bebida in Bebida.listaBebidas)
            {
                this.cmbBebidas.Items.Add(bebida.nombre);
            }


            if (tipoUbicacion is Mesa)
            {
                this.cmbComidas.Enabled = false;
                this.nudComidas.Enabled = false;
                this.cmbBebidas.Enabled = false;
                this.nudBebidas.Enabled = false;
            }
            else
            {
                this.cmbComidas.Enabled = false;
                this.nudComidas.Enabled = false;
                this.chkBebida.Visible = false;
                this.chkComida.Visible = false;
            }



        }

        /// <summary>
        /// Función que recibe un número de ubicación, y en base a ese parámetro,
        /// modifica el Título del formulario, guarda el tipo de ubicación,
        /// y retorna el número de la ubicación.
        /// </summary>
        /// <param name="numeroUbicacion"> Número de ubicación </param>
        /// <returns>Retorna número de ubicación</returns>
        public int SiEsMesaOBarra(int numeroUbicacion)
        {

            if (numeroUbicacion > 0 && numeroUbicacion <= 15)
            {
                this.Text = $"Mesa {numeroUbicacion}";
                tipoUbicacion = new Mesa();
                return numeroUbicacion;
            }
            else
            {
                this.Text = $"Barra {numeroUbicacion}";
                tipoUbicacion = new Barra();
                return numeroUbicacion;
            }
        }

        /// <summary>
        /// Botón que hará un pedido.
        /// </summary>
        private void btnHacerPedido_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\maurojas\Documents\Alumni\PPLBP\Sonidos\bloop.wav");
            player.Play();
            HacerPedido();

        }

        /// <summary>
        /// Función que hará el pedido y lo agregará al RichBox.
        /// </summary>
        public void HacerPedido()
        {
            MetodoDePago metodo;
            decimal stockNuevoComida = 0;
            decimal precioTotalComida = 0;
            decimal stockNuevoBebida = 0;
            decimal precioTotalBebida = 0;
            string nombreBebida = "Sin pedido";
            string nombreComida = "Sin pedido";


            switch (this.cmbMetodoDePago.Text)
            {
                case "Efectivo":
                    metodo = MetodoDePago.Efectivo;
                    break;
                case "Debito":
                    metodo = MetodoDePago.Debito;
                    break;
                default:
                    metodo = MetodoDePago.Credito;
                    break;
            }

            foreach (Comida comida in Comida.listaComidas)
            {
                if (comida.nombre == cmbComidas.Text)
                {
                    nombreComida = comida.nombre;
                    stockNuevoComida = comida.stock - nudComidas.Value;
                    precioTotalComida = comida.precio * nudComidas.Value;
                }
            }

            foreach (Bebida bebida in Bebida.listaBebidas)
            {
                if (bebida.nombre == cmbBebidas.Text)
                {
                    nombreBebida = bebida.nombre;
                    stockNuevoBebida = bebida.stock - nudBebidas.Value;
                    precioTotalBebida = bebida.precio * nudBebidas.Value;
                }
            }

            //if (chkEstacionamiento.Checked)
            //{
            //    precioTotalComida += 500;
            //    precioTotalBebida += 500;
            //}

            if (tipoUbicacion is Mesa)
            {
                if (chkComida.Checked && chkBebida.Checked)
                {
                    Pedido pedido = new Mesa(this.numeroUbicacion, metodo, precioTotalComida + precioTotalBebida, stockNuevoComida, nombreComida, nombreBebida, new Cliente(1, "A determinar"));
                    MessageBox.Show($"Mesa {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalComida + precioTotalBebida}, stock actual comida: {stockNuevoComida}, " +
                        $"stock actual bebida:{stockNuevoBebida}, pedido: {nudComidas.Value} {nombreComida}, {nudBebidas.Value} {nombreBebida}");
                }
                else if (chkComida.Checked && !chkBebida.Checked)
                {
                    Pedido pedido = new Mesa(this.numeroUbicacion, metodo, precioTotalComida, stockNuevoComida, nombreComida, new Cliente(1, "A determinar"));
                    MessageBox.Show($"Mesa {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalComida}, stock actual: {stockNuevoComida}, pedido: {nudComidas.Value} {nombreComida}");

                }
                else if (!chkComida.Checked && chkBebida.Checked)
                {
                    Pedido pedido = new Mesa(this.numeroUbicacion, metodo, precioTotalBebida, stockNuevoBebida, nombreBebida, new Cliente(1, "A determinar"));
                    MessageBox.Show($"Mesa {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalBebida}, stock actual: {stockNuevoBebida}, pedido: {nudComidas.Value} {nombreBebida}");

                }
            }
            else if (tipoUbicacion is Barra)
            {
                Pedido pedido = new Barra(this.numeroUbicacion, metodo, precioTotalBebida, stockNuevoBebida, nombreBebida, new Cliente(16, "A determinar)"));
                MessageBox.Show($"Barra {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalBebida}, stock actual: {stockNuevoBebida}, pedido: {nudBebidas.Value} {nombreBebida}");
            }
        }

        /// <summary>
        /// Función que define si se marca el check de bebida o comida
        /// para así poder hacer el pedido correspondiente.
        /// </summary>
        public void SiQuiereComidaOBebida()
        {
            if (tipoUbicacion is Mesa)
            {
                if (chkComida.Checked && chkBebida.Checked)
                {
                    this.cmbComidas.Enabled = true;
                    this.nudComidas.Enabled = true;
                    this.cmbBebidas.Enabled = true;
                    this.nudBebidas.Enabled = true;
                }
                else if (!chkComida.Checked && !chkBebida.Checked)
                {
                    this.cmbComidas.Enabled = false;
                    this.nudComidas.Enabled = false;
                    this.cmbBebidas.Enabled = false;
                    this.nudBebidas.Enabled = false;
                }
                else if (chkComida.Checked && !chkBebida.Checked)
                {
                    this.cmbComidas.Enabled = true;
                    this.nudComidas.Enabled = true;
                    this.cmbBebidas.Enabled = false;
                    this.nudBebidas.Enabled = false;
                }
                else if (!chkComida.Checked && chkBebida.Checked)
                {
                    this.cmbComidas.Enabled = false;
                    this.nudComidas.Enabled = false;
                    this.cmbBebidas.Enabled = true;
                    this.nudBebidas.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Funcionalidad que se aplica cada vez que se presiona un check
        /// llamará a la función SiQuiereComidaOBebida y actualizará las secciones.
        /// </summary>
        private void chkComidaBebida_CheckedChanged(object sender, EventArgs e)
        {
            SiQuiereComidaOBebida();
        }


        /// <summary>
        /// Botón que cerrará toda la aplicación.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Botón que irá un pasó atrás en la aplicación.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
