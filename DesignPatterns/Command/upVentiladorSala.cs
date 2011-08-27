using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State;

namespace Command
{
    public class upVentiladorSala : ICommand
    {
        VentiladorTeto _VentiladorTeto;

        public upVentiladorSala(VentiladorTeto ventiladorTeto)
        {
            this._VentiladorTeto = ventiladorTeto;
        }

        public void Executar()
        {
            this._VentiladorTeto.AumentarVelocidade();
        }
    }
}
