using System;
namespace proyecto_final
{
	public class NinosPlugin:IPlugin
	{
		public NinosPlugin()
		{
		}
        public List<T> AplicarPlugin<T>(List<T> contenido)
        {
            return contenido.Where(c => ((Audiolibro)(object)c).MatureContent == false).ToList();
        }
    }
}

