using System;
using Newtonsoft.Json;
namespace proyecto_final
{
    public static class JsonLoader
    {
        public static T LoadFromJson<T>(string filePath)
        {
            var jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }

}

