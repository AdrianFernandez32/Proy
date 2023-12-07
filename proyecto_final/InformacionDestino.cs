using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public class InformacionDestino : InformacionCheck
    {
        [JsonProperty("codigo_aeropuerto")]
        public string CodigoAeropuerto { get; set; }

        [JsonProperty("ciudad")]
        public string Ciudad { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("zona_horaria")]
        public string ZonaHoraria { get; set; }

        public override void ShowInfo()
        {
            // Implementar la lógica para mostrar la información del destino
        }

        public static InformacionDestino LoadFromJson(string filePath)
        {
            var jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<InformacionDestino>(jsonData);
        }
    }

}

