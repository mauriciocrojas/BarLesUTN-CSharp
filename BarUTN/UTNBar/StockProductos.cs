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
    public partial class StockProductos : Form
    {
        public StockProductos()
        {
            InitializeComponent();
        }

        private void StockProductos_Load(object sender, EventArgs e)
        {
            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            bebidas.HardcodearBebidas();
            comidas.HardcodearComidas();

            this.rchStock.Text = bebidas.MostrarStock() + comidas.MostrarStock();
        }
    }
}
