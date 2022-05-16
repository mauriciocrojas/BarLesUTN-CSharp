using System.Collections.Generic;

namespace Entidades
{
    public class Mesa : Pedido
    {
        static Mesa[] mesas;
        Cliente cliente;


        static Mesa()
        {
            HardcodearMesas();
        }
        public Mesa() { }
        public Mesa(int numeroUbicacion, MetodoDePago metodoDePago, decimal precio, decimal stock, string nombreComida, Cliente cliente)
            : base(numeroUbicacion, metodoDePago, precio, stock, nombreComida)
        {
            this.cliente = cliente;
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { cliente = value; }
        }

        public static void HardcodearMesas()
        {
            mesas = new Mesa[]
            {

            new Mesa(1, MetodoDePago.Efectivo, 215, 5, "Verduras al vapor", new Cliente(1, "Ernesto")),
            new Mesa(2, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(3, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(4, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(5, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(6, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(7, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(8, MetodoDePago.Debito, 215, 5, "Pastel de choclo", new Cliente(9, "Jack")),
            new Mesa(9, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(10, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(11, MetodoDePago.Credito, 215, 5, "Merluza con puré", new Cliente(13, "Ston")),
            new Mesa(12, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(13, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(14, MetodoDePago.Efectivo, 0, 0, "--", null),
            new Mesa(15, MetodoDePago.Efectivo, 0, 0, "--", null)
            };
        }

        public static Dictionary<int, bool> MesasOcupadas()
        {
            Dictionary<int, bool> mesasOcupadas = new Dictionary<int, bool>();

            for (int i = 0; i < mesas.Length; i++)
            {
                mesasOcupadas.Add(i + 1, mesas[i].Cliente is null);
            }

            return mesasOcupadas;
        }
    }
}
