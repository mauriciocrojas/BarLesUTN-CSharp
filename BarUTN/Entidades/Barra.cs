using System.Collections.Generic;

namespace Entidades
{
    public class Barra : Pedido
    {
        static Barra[] barra;
        Cliente cliente;
        static Barra()
        {
            HardcodearBarra();
        }
        public Barra() { }
        public Barra(int numeroUbicacion, MetodoDePago metodoDePago, decimal precio, decimal stock, string nombreBebida, Cliente cliente)
            : base(numeroUbicacion, metodoDePago, precio, stock, nombreBebida)
        {
            this.cliente = cliente;

        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { cliente = value; }
        }

        public static void HardcodearBarra()
        {
            barra = new Barra[]
            {

            new Barra(16, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Barra(17, MetodoDePago.Debito, 215, 5, "Gin Tonic", new Cliente(17, "Wayne")),
            new Barra(18, MetodoDePago.Efectivo, 215, 5, "Gin Tonic", new Cliente(18, "Bruce")),
            new Barra(19, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Barra(20, MetodoDePago.Efectivo, 0, 0, "--", null)
            };
        }

        /// <summary>
        /// Función de clase que recorre la barra, asigna un id y un cliente a la misma.
        /// </summary>
        /// <returns>Retornará true si cliente es null, false si no lo es</returns>
        public static Dictionary<int, bool> BarraOcupada()
        {
            Dictionary<int, bool> barraOcupada = new Dictionary<int, bool>();

            for (int i = 0; i < barra.Length; i++)
            {
                barraOcupada.Add(i + 1, barra[i].Cliente is null);
            }

            return barraOcupada;
        }
    }
}
