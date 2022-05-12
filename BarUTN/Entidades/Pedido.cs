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

        public MetodoDePago metodoDePago;

        public Pedido() { }
        public Pedido (int numeroUbicacion, MetodoDePago metodoDePago) : this()
        {
            this.numeroUbicacion = numeroUbicacion;
            this.metodoDePago = metodoDePago;
        }
    }
}
