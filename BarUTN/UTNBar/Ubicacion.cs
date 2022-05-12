using Entidades;
using System;
using System.Windows.Forms;

namespace UTNBar
{
    public partial class Ubicacion : Form
    {
        Pedido tipoUbicacion;
        public int numeroUbicacion;
        public Ubicacion(int ubicacion)
        {
            InitializeComponent();
            this.numeroUbicacion = SiEsMesaOBarra(ubicacion);
        }

        private void Ubicacion_Load(object sender, EventArgs e)
        {
            //this.cmbComidas.Items.Add("Verduras al vapor");
            //this.cmbComidas.Items.Add("Pastel de choclo");
            //this.cmbComidas.Items.Add("Merluza con puré");
            //this.cmbBebidas.Items.Add("Gin Tonic");
            //this.cmbBebidas.Items.Add("Seven Up");
            //this.cmbBebidas.Items.Add("Agua sin gas");

            this.cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoDePago));

            Comida.HardcodearComidas();
            Bebida.HardcodearBebidas();

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

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            HacerPedido();
        }

        public void HacerPedido()
        {
            MetodoDePago metodo;
            decimal stockNuevoComida;
            decimal precioTotalComida; 
            decimal stockNuevoBebida;
            decimal precioTotalBebida;
            string nombreBebida;
            string nombreComida;

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
                if (cmbComidas.Text == comida.nombre)
                {
                    nombreComida = comida.nombre;
                    stockNuevoComida = comida.stock - nudComidas.Value;
                    precioTotalComida = comida.precio * nudComidas.Value;
                }
                else
                {
                    nombreComida = "Inexistente";
                    stockNuevoComida = 0;
                    precioTotalComida = 0;
                }
            }

            foreach (Bebida bebida in Bebida.listaBebidas)
            {
                if (cmbBebidas.Text == bebida.nombre)
                {
                    nombreBebida = bebida.nombre;
                    stockNuevoBebida = bebida.stock - nudBebidas.Value;
                    precioTotalBebida = bebida.precio * nudBebidas.Value;
                }
                else
                {
                    nombreBebida = "Inexistente";
                    stockNuevoBebida = 0;
                    precioTotalBebida = 0;
                }
            }

            //switch (cmbComidas.Text)
            //{
            //    case "Verduras al vapor":
            //        nombreComida = "Verduras al vapor";
            //        stockNuevoComida = Comida.listaComidas[0].stock - nudComidas.Value;
            //        precioTotalComida = Comida.listaComidas[0].precio * nudComidas.Value;
            //        break;
            //    case "Pastel de choclo":
            //        nombreComida = "Pastel de choclo";
            //        stockNuevoComida = Comida.listaComidas[1].stock - nudComidas.Value;
            //        precioTotalComida = Comida.listaComidas[1].precio * nudComidas.Value;
            //        break;
            //    case "Merluza con puré":
            //        nombreComida = "Merluza con puré";
            //        stockNuevoComida = Comida.listaComidas[2].stock - nudComidas.Value;
            //        precioTotalComida = Comida.listaComidas[2].precio * nudComidas.Value;
            //        break;
            //    default:
            //        nombreComida = "Inexistente";
            //        stockNuevoComida = 0;
            //        precioTotalComida = 0;
            //        break;
            //}

            //switch (cmbBebidas.Text)
            //{
            //    case "Gin tonic":
            //        nombreBebida = "Gin tonic";
            //        stockNuevoBebida = Bebida.listaBebidas[0].stock - nudBebidas.Value;
            //        precioTotalBebida = Bebida.listaBebidas[0].precio * nudBebidas.Value;
            //        break;
            //    case "Seven Up":
            //        nombreBebida = "Seven Up";
            //        stockNuevoBebida = Bebida.listaBebidas[1].stock - nudBebidas.Value;
            //        precioTotalBebida = Bebida.listaBebidas[1].precio * nudBebidas.Value;
            //        break;
            //    case "Agua sin gas":
            //        nombreBebida = "Agua sin gas";
            //        stockNuevoBebida = Bebida.listaBebidas[2].stock - nudBebidas.Value;
            //        precioTotalBebida = Bebida.listaBebidas[2].precio * nudBebidas.Value;
            //        break;
            //    default:
            //        nombreBebida = "Inexistente";
            //        stockNuevoBebida = 0;
            //        precioTotalBebida = 0;
            //        break;
            //}

            if (tipoUbicacion is Mesa)
            {
                Pedido pedido = new Mesa(this.numeroUbicacion, metodo, precioTotalComida, stockNuevoComida, nombreComida);

                MessageBox.Show($"Mesa {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalComida}, stock: {stockNuevoComida}, pedido: {nombreComida}");

            }
            else if (tipoUbicacion is Barra)
            {
                Pedido pedido = new Barra(this.numeroUbicacion, metodo, precioTotalBebida, stockNuevoBebida, nombreBebida);
                MessageBox.Show($"Barra {numeroUbicacion}, Método de pago: {metodo}, ${precioTotalBebida}, stock: {stockNuevoBebida}, pedido: {nombreBebida}");

            }
        }

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


        private void chkComidaBebida_CheckedChanged(object sender, EventArgs e)
        {
            SiQuiereComidaOBebida();

        }


    }
}
