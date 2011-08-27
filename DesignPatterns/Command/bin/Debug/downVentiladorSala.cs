using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State;

namespace Command
{
   public class downVentiladorSala:ICommand
    {
        VentiladorTeto _VentiladorTeto;

        public downVentiladorSala(VentiladorTeto ventiladorTeto)
        {
            this._VentiladorTeto = ventiladorTeto;
        }

        public void Executar()
        {
            this._VentiladorTeto.DiminuirVelocidade();
        }
    }
}
