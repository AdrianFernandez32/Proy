using System;
namespace proyecto_final
{
    public class ComprasStrategy : IStrategy
    {
        private CarritoCompra _carritoCompra;

        public ComprasStrategy(CarritoCompra carritoCompra)
        {
            _carritoCompra = carritoCompra;
        }

        public void Execute()
        {
            // no hay nada
            _carritoCompra.Checkout();
        }
    }

}

