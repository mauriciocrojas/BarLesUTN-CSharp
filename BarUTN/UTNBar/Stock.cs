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
        private string nameWindow;
        public Stock()
        {
            InitializeComponent();
        }

        public Stock (string nameWindow):this()
        {
            this.nameWindow = nameWindow;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Bebida bebidas = new Bebida();
            Comida comidas = new Comida();

            bebidas.HardcodearBebidas();
            comidas.HardcodearComidas();

            this.Text = this.nameWindow;
            this.richTextBox1.Text = bebidas.MostrarStock() + comidas.MostrarStock();

        }
    }
}
