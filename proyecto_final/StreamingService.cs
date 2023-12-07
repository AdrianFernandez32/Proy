using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public abstract class StreamingService
    {
        [JsonProperty("titulo")]
        public string Titulo { get; set; }

        [JsonProperty("imagen")]
        public string Imagen { get; set; }

        [JsonProperty("duracion")]
        public int Duracion { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("matureContent")]
        public bool MatureContent { get; set; }

        public abstract string Play();
    }
}


