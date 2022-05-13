using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Bebida : Stock
    {
        public static List<Bebida> listaBebidas;

        protected decimal peso;
        protected ETipoBebida tipo;

        public Bebida()
        {
            listaBebidas = new List<Bebida>();

        }
        public Bebida(string nombre, decimal peso, ETipoBebida tipo, decimal stock, decimal precio) : base(nombre, stock, precio)
        {
            this.peso = peso;
            this.tipo = tipo;
            listaBebidas = new List<Bebida>();
        }


        public static void HardcodearBebidas()
        {
            Bebida bebida1 = new Bebida("Gin tonic", 375, ETipoBebida.Alcoholicas, 20, 500);
            Bebida bebida2 = new Bebida("Seven Up", 500, ETipoBebida.Gasificadas, 30, 300);
            Bebida bebida3 = new Bebida("Agua sin gas", 400, ETipoBebida.Aguas, 40, 250);

            listaBebidas.Add(bebida1);
            listaBebidas.Add(bebida2);
            listaBebidas.Add(bebida3);
        }

        public override string MostrarStock()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Bebida bebida in listaBebidas)
            {
                sb.Append($"Bebida: {bebida.nombre} ${bebida.precio}, {bebida.peso}ml, tipo: {bebida.tipo}, stock: {bebida.stock}\n");
            }

            return sb.ToString();
        }

        public static void AgregarNuevaBebida(string nombre, decimal peso, ETipoBebida tipo, decimal stock, decimal precio)
        {
            Bebida bebida = new Bebida(nombre, peso, tipo, stock, precio);
            listaBebidas.Add(bebida);
        }
    }
}
