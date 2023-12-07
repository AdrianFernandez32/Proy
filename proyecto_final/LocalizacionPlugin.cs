using System;
namespace proyecto_final
{
	public class LocalizacionPlugin:IPlugin
	{
		public LocalizacionPlugin()
		{
		}
		public List<T> AplicarPlugin<T>(List<T> contenido) {
           return contenido.Where(c => ((Audiolibro)(object)c).Restricted).ToList();
        }
    }
}

