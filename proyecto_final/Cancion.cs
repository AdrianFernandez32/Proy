using System;
using Newtonsoft.Json;

namespace proyecto_final
{
    public class Cancion : StreamingService
    {
        public override string Play()
        {
            return $"Reproduciendo Canción: {Titulo}";
        }
    }
}

