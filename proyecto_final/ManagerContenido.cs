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
			//get informacion de la seleecion
			//filtrar con aplicarPlugins
			//display

		}

		public int ImprimirMenu() {
			Console.WriteLine("--------------------- \n 1) peliculas \n 2) series \n 3) informacion de vuelo");
			string response = Console.ReadLine();
			int responseNumber = Int32.Parse(response);
			return responseNumber;
		}

	}
}

