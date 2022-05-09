using System;

namespace Entidades
{
    public abstract class Stock
    {
        protected string nombre;
        protected decimal stock;
        protected decimal precio;
        
        public Stock()
        {

        }
        public Stock(string nombre, decimal stock, decimal precio)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;

         }

        public abstract string MostrarStock();
    }
}
