using System;
namespace proyecto_final
{
    public class InformacionStrategy : IStrategy
    {
        private InformacionCheck _informacionCheck;

        public InformacionStrategy(InformacionCheck informacionCheck)
        {
            _informacionCheck = informacionCheck;
        }

        public void Execute()
        {
            // Puede mostrar la información de destino y vuelo
            _informacionCheck.ShowInfo();
        }
    }

}

