using System;
namespace proyecto_final
{
	public class ProxyMensaje:IMensaje
	{
		public ProxyMensaje()
		{
		}
        public void ImprimirMensaje()
        {
			Console.WriteLine("...");
        }
    }
}

