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
    public partial class Stock : Form
    {
        private string nombreVentanaStock;

        public Stock (string nombreVentanaStock)
        {
            InitializeComponent();
            this.nombreVentanaStock = nombreVentanaStock;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            bebidas.HardcodearBebidas();
            comidas.HardcodearComidas();

            this.Text = this.nombreVentanaStock;
            this.rchListaStock.Text = bebidas.MostrarStock() + comidas.MostrarStock();

        }
    }
}
