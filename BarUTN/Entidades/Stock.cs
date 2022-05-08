using System;

namespace Entidades
{
    public abstract class Stock
    {
        protected string nombre;
        protected int stock;
        
        public Stock()
        {

        }
        public Stock (string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        public abstract string MostrarStock();
    }
}
