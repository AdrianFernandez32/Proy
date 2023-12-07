using System;
using proyecto_final;

namespace proyecto_final
{
    public class Pelicula : StreamingService
    {
        public override string Play()
        {
            return $"Reproduciendo película: {Titulo}";
        }
    }
}

