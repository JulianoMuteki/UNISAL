using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class EstadoDesligado : IState
    {
        public string Velocidade { get;  set; }

        public EstadoDesligado()
        {
            Velocidade = "Desligado";
        }
        public void AumentarVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoBaixo();
        }

        public void DiminuirVelocidade(VentiladorTeto ventilador)
        {
            Console.WriteLine("Já está desligado.");
        }
    }
}
