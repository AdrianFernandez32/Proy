using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace proyecto_final
{
    public static class JsonLoader
    {
        private const string ArticulosJsonPath = "../../../info/DutyFree/Articulos.json";
        private const string AudiolibrosJsonPath = "../../..//info/Entretainment/Audiolibros.json";
        private const string CancionesJsonPath = "../../../info/Entretainment/Canciones.json";
        private const string PeliculasJsonPath = "../../..//info/Entretainment/Peliculas.json";
        private const string SeriesJsonPath = "../../..//info/Entretainment/Series.json";
        private const string InfoVueloJsonPath = "../../../info/info/InfoVuelo.json";
        private const string InfoDestinoJsonPath = "../../../info/info/InfoDestino.json";

        public static List<Item> LoadArticulos()
        {
            try
            {
                var jsonData = File.ReadAllText(ArticulosJsonPath);
                return JsonConvert.DeserializeObject<List<Item>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Articulos: {ex.Message}");
                return new List<Item>();
            }
        }

        public static List<Audiolibro> LoadAudiolibros()
        {
            try
            {
                var jsonData = File.ReadAllText(AudiolibrosJsonPath);
                return JsonConvert.DeserializeObject<List<Audiolibro>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Audiolibros: {ex.Message}");
                return new List<Audiolibro>();
            }
        }

        public static List<Cancion> LoadCanciones()
        {
            try
            {
                var jsonData = File.ReadAllText(CancionesJsonPath);
                return JsonConvert.DeserializeObject<List<Cancion>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Canciones: {ex.Message}");
                return new List<Cancion>();
            }
        }

        public static List<Pelicula> LoadPeliculas()
        {
            try
            {
                var jsonData = File.ReadAllText(PeliculasJsonPath);
                return JsonConvert.DeserializeObject<List<Pelicula>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Peliculas: {ex.Message}");
                return new List<Pelicula>();
            }
        }

        public static List<Serie> LoadSeries()
        {
            try
            {
                var jsonData = File.ReadAllText(SeriesJsonPath);
                return JsonConvert.DeserializeObject<List<Serie>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Series: {ex.Message}");
                return new List<Serie>();
            }
        }

        public static InformacionVuelo LoadInformacionVuelo()
        {
            try
            {
                var jsonData = File.ReadAllText(InfoVueloJsonPath);
                return JsonConvert.DeserializeObject<InformacionVuelo>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Información de Vuelo: {ex.Message}");
                return null;
            }
        }

        public static InformacionDestino LoadInformacionDestino()
        {
            try
            {
                var jsonData = File.ReadAllText(InfoDestinoJsonPath);
                return JsonConvert.DeserializeObject<InformacionDestino>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar Información de Destino: {ex.Message}");
                return null;
            }
        }
    }
}
