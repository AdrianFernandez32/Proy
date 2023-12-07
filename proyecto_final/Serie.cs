using System;
using proyecto_final;

namespace proyecto_final
{
    public class Serie : StreamingService
    {
        public override string Play()
        {
            return $"Reproduciendo serie: {Titulo}";
        }
    }
}


