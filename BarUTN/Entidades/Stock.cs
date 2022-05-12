using System;

namespace Entidades
{
    public abstract class Stock
    {
        public string nombre;
        public decimal stock;
        public decimal precio;
        
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
