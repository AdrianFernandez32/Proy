using System;
namespace proyecto_final
{
    public class Audiolibro : StreamingService
    {
        public override string Play()
        {
            return $"Reproduciendo audiolibro: {Titulo}";
        }
    }
}

