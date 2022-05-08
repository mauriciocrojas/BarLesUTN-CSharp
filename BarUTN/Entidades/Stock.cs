using System;

namespace Entidades
{
    public abstract class Stock
    {
        protected string nombre;
        protected int stock;
        protected int precio;
        
        public Stock()
        {

        }
        public Stock(string nombre, int stock, int precio)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;

         }

        public abstract string MostrarStock();
    }
}
