namespace Entidades
{
    public class Barra : Pedido
    {
        public Barra() { }
        public Barra(int numeroUbicacion, MetodoDePago metodoDePago, decimal precio, decimal stock, string nombreBebida)
            : base(numeroUbicacion, metodoDePago, precio, stock, nombreBebida)
        {
        }
    }
}
