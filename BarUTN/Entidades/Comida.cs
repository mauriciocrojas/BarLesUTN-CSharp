using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Comida : Stock
    {
        protected bool sinSal;
        public List<Comida> listaComidas;

        public Comida()
        {
            listaComidas = new List<Comida>();

        }
        public Comida(string nombre, bool sinSal, int stock) : base(nombre, stock)
        {
            this.sinSal = sinSal;
            listaComidas = new List<Comida>();
        }

        public void HardcodearComidas()
        {
            Comida comida1 = new Comida("Verduras al vapor", true, 15);
            Comida comida2 = new Comida("Pastel de choclo", false, 30);
            Comida comida3 = new Comida("Merluza con puré", false, 45);

            listaComidas.Add(comida1);
            listaComidas.Add(comida2);
            listaComidas.Add(comida3);
        }

        public override string MostrarStock()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Comida comida in listaComidas)
            {
                string auxSal = comida.sinSal ? "sin sal" : "con sal";
                sb.Append($"Comida: {comida.nombre}, Producto: {auxSal}, stock: {comida.stock}\n");
            }

            return sb.ToString();
        }
    }
}
