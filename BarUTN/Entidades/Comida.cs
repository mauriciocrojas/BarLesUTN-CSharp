using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Comida : Stock
    {
        protected bool sinSal;
        public static List<Comida> listaComidas;

        static Comida()
        {
            listaComidas = new List<Comida>();
            Comida.HardcodearComidas();
        }
        public Comida()
        {

        }
        public Comida(string nombre, bool sinSal, decimal stock, decimal precio) : base(nombre, stock, precio)
        {
            this.sinSal = sinSal;
        }

        public static void HardcodearComidas()
        {
            Comida comida1 = new Comida("Verduras al vapor", true, 15, 700);
            Comida comida2 = new Comida("Pastel de choclo", false, 30, 900);
            Comida comida3 = new Comida("Merluza con puré", false, 45, 800);

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
                sb.Append($"Comida: {comida.nombre} ${comida.precio}, Producto: {auxSal}, stock: {comida.stock}\n");
            }

            return sb.ToString();
        }

        public static void AgregarNuevaComida(string nombre, bool sinSal, decimal stock, decimal precio)
        {
            Comida comida = new Comida(nombre, sinSal, stock, precio);
            listaComidas.Add(comida);
        }
    }
}
