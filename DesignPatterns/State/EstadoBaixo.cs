using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class EstadoBaixo:IState
    {
        public string Velocidade { get;  set; }

        public EstadoBaixo()
        {
            Velocidade = "Baixo";
        }
        public void AumentarVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoMedio();
        }

        public void DiminuirVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoDesligado();
        }
    }
}
