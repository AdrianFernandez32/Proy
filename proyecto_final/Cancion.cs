using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public class Cancion : StreamingService
    {
        [JsonProperty("artista")]
        public string Artista { get; set; }
    }
}

