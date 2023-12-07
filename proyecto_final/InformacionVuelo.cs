using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public class InformacionVuelo : InformacionCheck
    {
        [JsonProperty("numero_de_vuelo")]
        public string NumeroDeVuelo { get; set; }

        [JsonProperty("aerolinea")]
        public string Aerolinea { get; set; }

        [JsonProperty("hora_de_salida")]
        public DateTime HoraDeSalida { get; set; }

        [JsonProperty("estado_del_vuelo")]
        public string EstadoDelVuelo { get; set; }

        public override void ShowInfo()
        {
            // no hay nada aun
        }

        public static InformacionVuelo LoadFromJson(string filePath)
        {
            var jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<InformacionVuelo>(jsonData);
        }
    }

}

