using System;
namespace proyecto_final
{
	public class ManagerContenido
	{
		IPlugin[] PluginLIst;
		public ManagerContenido()
		{
		}

		public void AplicarPlugins() { 
			foreach(IPlugin plugin in PluginLIst) {
				//hacer cosas aqui 
			}
		}

		public void RunApp() {
			int seleccion = this.ImprimirMenu();
			Console.WriteLine(seleccion);
			string response = Console.ReadLine();
			//get informacion de la seleecion
			//filtrar con aplicarPlugins
			//display

		}

		public int ImprimirMenu() {
			string[] info = { "MENU","1) Vuelo", "2) Comprar", "3) Entretenimiento" };
			Mensaje mensaje = new Mensaje(info);
			mensaje.ImprimirMensaje();

			string response = Console.ReadLine();
			int responseNumber = Int32.Parse(response);
			return responseNumber;
		}

	}
}

