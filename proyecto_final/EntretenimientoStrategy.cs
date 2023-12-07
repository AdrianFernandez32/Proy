using System;
namespace proyecto_final
{
    public class EntretenimientoStrategy : IStrategy
    {
        private StreamingService _streamingService;

        public EntretenimientoStrategy(StreamingService streamingService)
        {
            _streamingService = streamingService;
        }

        public void Execute()
        {
            // faltan cosas
            _streamingService.Play();
        }
    }

}

