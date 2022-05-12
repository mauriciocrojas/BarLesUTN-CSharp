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
            if (tipoUbicacion is Mesa)
            {
                Pedido pedido = new Mesa(this.numeroUbicacion, metodo);

                MessageBox.Show($"Mesa {numeroUbicacion}, Método de pago: {metodo}");

            }
            else
            {
                Pedido pedido = new Barra(this.numeroUbicacion, metodo);
                MessageBox.Show($"Barra {numeroUbicacion}, Método de pago: {metodo}");

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
