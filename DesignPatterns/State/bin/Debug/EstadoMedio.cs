using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class EstadoMedio:IState
    {
        public string Velocidade { get;  set; }

        public EstadoMedio()
        {
            Velocidade = "Medio";
        }
        public void AumentarVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoAlto();
        }

        public void DiminuirVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoBaixo();
        }
    }
}
