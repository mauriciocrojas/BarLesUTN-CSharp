using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa : Pedido
    {
        public Mesa() { }
        public Mesa(int numeroUbicacion, MetodoDePago metodoDePago) : base(numeroUbicacion, metodoDePago)
        {

        }
    }
}
