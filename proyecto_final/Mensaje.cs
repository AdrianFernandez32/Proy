using System;
namespace proyecto_final
{
	public class Mensaje:IMensaje
	{
		string[] infoList;
		public Mensaje(string[] infoList)
		{
			this.infoList = infoList;
		}

		public void ImprimirMensaje() {
			Console.WriteLine("--------------------");
			foreach (string line in this.infoList) {
				Console.WriteLine(line);
			}
			Console.WriteLine("--------------------");
		}
	}
}

