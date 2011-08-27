using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public interface IState
    {
        void AumentarVelocidade(VentiladorTeto ventilador);
        void DiminuirVelocidade(VentiladorTeto ventilador);
         string Velocidade { get;  set; }
    }
}
