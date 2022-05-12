using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int numeroUbicacion;
        public decimal precio;
        public decimal stock;
        public string nombrePedido;

        public MetodoDePago metodoDePago;

        public Pedido() { }
        public Pedido (int numeroUbicacion, MetodoDePago metodoDePago, decimal precio, decimal stock, string nombrePedido) : this()
        {
            this.numeroUbicacion = numeroUbicacion;
            this.metodoDePago = metodoDePago;
            this.precio = precio;
            this.stock = stock;
            this.nombrePedido = nombrePedido;
        }
    }
}
