using System;
namespace proyecto_final
{
    public class CensuraPlugin : IPlugin
    {
        public CensuraPlugin()
        {
        }
        public List<T> AplicarPlugin<T>(List<T> contenido)
        {
            Random random = new Random();

            return contenido.Where(c => random.NextDouble() < 0.5).ToList();
        }
    }
}

