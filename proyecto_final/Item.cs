using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public class Item
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("precio")]
        public double Precio { get; set; }

        [JsonProperty("marca")]
        public string Marca { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }

}

