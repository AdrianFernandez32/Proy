using System;
using proyecto_final;

namespace proyecto_final
{
	public class ManagerContenido
	{
		IPlugin[] PluginLIst;

        private IStrategy _estrategiaActual;
        private readonly string _articulosJsonPath = "./info/DutyFree/Articulos.json";
        private readonly string _audiolibrosJsonPath = "./info/Entretainment/Audiolibros.json";
        private readonly string _cancionesJsonPath = "./info/Entretainment/Canciones.json";
        private readonly string _peliculasJsonPath = "./info/Entretainment/Peliculas.json";
        private readonly string _seriesJsonPath = "./info/Entretainment/Series.json";
        private readonly string _infoVueloJsonPath = "./info/info/InfoVuelo.json";
        private readonly string _infoDestinoJsonPath = "./info/info/InfoDestino.json";

        public ManagerContenido()
		{
		}

		public void AplicarPlugins() { 
			foreach(IPlugin plugin in PluginLIst) {
				//hacer cosas aqui 
			}
		}

        public void RunApp()
        {
            while (true)
            {
                int seleccion = ImprimirMenuPrincipal();
                switch (seleccion)
                {
                    case 1:
                        SeleccionarEstrategiaInformacion();
                        break;
                    case 2:
                        SeleccionarEstrategiaCompras();
                        break;
                    case 3:
                        SeleccionarEstrategiaEntretenimiento();
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            }
        }

        private int ImprimirMenuPrincipal()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1) Información");
            Console.WriteLine("2) Compras");
            Console.WriteLine("3) Entretenimiento");
            Console.Write("Opción: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                return seleccion;
            }
            return -1;
        }

        private void SeleccionarEstrategiaInformacion()
        {
            Console.WriteLine("Seleccione el tipo de información:");
            Console.WriteLine("1) Información de Vuelo");
            Console.WriteLine("2) Información de Destino");
            Console.Write("Opción: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                switch (seleccion)
                {
                    case 1:
                        var infoVuelo = JsonLoader.LoadInformacionVuelo();
                        _estrategiaActual = new InformacionStrategy(infoVuelo);
                        break;
                    case 2:
                        var infoDestino = JsonLoader.LoadInformacionDestino();
                        _estrategiaActual = new InformacionStrategy(infoDestino);
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        return;
                }
                _estrategiaActual.Execute();
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        private void SeleccionarEstrategiaCompras()
        {
            var carritoCompra = new CarritoCompra();
            var articulos = JsonLoader.LoadArticulos();
            Console.WriteLine("Seleccione los artículos que desea añadir al carrito:");
            for (int i = 0; i < articulos.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {articulos[i].Nombre} - ${articulos[i].Precio}");
            }
            Console.WriteLine("Ingrese los números de los artículos separados por comas o 'checkout' para finalizar:");
            string input = Console.ReadLine();
            if (input.ToLower() == "checkout")
            {
                // Ejecutar estrategia de checkout
                _estrategiaActual = new ComprasStrategy(carritoCompra);
                _estrategiaActual.Execute();
                return;
            }

            var indicesSeleccionados = input.Split(',');
            foreach (var indice in indicesSeleccionados)
            {
                if (int.TryParse(indice.Trim(), out int indiceArticulo))
                {
                    if (indiceArticulo >= 1 && indiceArticulo <= articulos.Count)
                    {
                        carritoCompra.AddItem(articulos[indiceArticulo - 1]);
                    }
                    else
                    {
                        Console.WriteLine($"Artículo {indiceArticulo} no válido.");
                    }
                }
                else
                {
                    Console.WriteLine($"Entrada '{indice}' no válida.");
                }
            }
        }

        private void SeleccionarEstrategiaEntretenimiento()
        {
            Console.WriteLine("Seleccione el tipo de entretenimiento:");
            Console.WriteLine("1) Audiolibros");
            Console.WriteLine("2) Música");
            Console.WriteLine("3) Películas");
            Console.WriteLine("4) Series de televisión");
            Console.Write("Opción: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                switch (seleccion)
                {
                    case 1:
                        MostrarContenido<Audiolibro>();
                        break;
                    case 2:
                        MostrarContenido<Cancion>();
                        break;
                    case 3:
                        MostrarContenido<Pelicula>();
                        break;
                    case 4:
                        MostrarContenido<Serie>();
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        private void MostrarContenido<T>() where T : StreamingService, new()
        {
            List<T> contenidos;

            if (typeof(T) == typeof(Audiolibro))
            {
                contenidos = JsonLoader.LoadAudiolibros() as List<T>;
            }
            else if (typeof(T) == typeof(Cancion))
            {
                contenidos = JsonLoader.LoadCanciones() as List<T>;
            }
            else if (typeof(T) == typeof(Pelicula))
            {
                contenidos = JsonLoader.LoadPeliculas() as List<T>;
            }
            else if (typeof(T) == typeof(Serie))
            {
                contenidos = JsonLoader.LoadSeries() as List<T>;
            }
            else
            {
                Console.WriteLine("Tipo de contenido no soportado.");
                return;
            }

            Console.WriteLine("Seleccione el contenido que desea ver:");
            for (int i = 0; i < contenidos.Count; i++)
            {
                T contenido = contenidos[i];
                Console.WriteLine($"{i + 1}) {contenido.Titulo} - Duración: {contenido.Duracion} minutos");
            }
            Console.Write("Opción: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= contenidos.Count)
            {
                T contenidoSeleccionado = contenidos[seleccion - 1];
                string resultadoReproduccion = contenidoSeleccionado.Play();
                Console.WriteLine(resultadoReproduccion);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }


    }
}

