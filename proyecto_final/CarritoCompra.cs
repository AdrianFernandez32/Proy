using System;
namespace proyecto_final
{
    public class CarritoCompra
    {
        public List<Item> Items { get; set; }

        public CarritoCompra()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void DeleteItem(Item item)
        {
            Items.Remove(item);
        }

        public void Checkout()
        {
            Console.WriteLine("Gracias por su compra, se cargará a su tarjeta");
        }
    }
}

