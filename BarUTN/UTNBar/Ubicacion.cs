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
    public partial class Ubicacion : Form
    {
        Pedido tipoUbicacion;
        public Ubicacion(int ubicacion)
        {
            InitializeComponent();
            ubicacion = SiEsMesaOBarra(ubicacion);
        }

        private void Ubicacion_Load(object sender, EventArgs e)
        {
            this.cmbComidas.Items.Add("Verduras al vapor");
            this.cmbComidas.Items.Add("Pastel de choclo");
            this.cmbComidas.Items.Add("Merluza con puré");

            this.cmbBebidas.Items.Add("Gin Tonic");
            this.cmbBebidas.Items.Add("Seven Up");
            this.cmbBebidas.Items.Add("Agua sin gas");


            if (tipoUbicacion is Mesa)
            {
               
            }
            else
            {
                this.cmbComidas.Enabled = false;
                this.nudComidas.Enabled = false;
            }

        }

        public int SiEsMesaOBarra (int numeroUbicacion)
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
    }
}
