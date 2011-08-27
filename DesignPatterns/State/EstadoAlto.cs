using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class EstadoAlto:IState
    {
        public string Velocidade { get;  set; }

        public EstadoAlto()
        {
            Velocidade = "Alto";
        }

        public void AumentarVelocidade(VentiladorTeto ventilador)
        {
            Console.WriteLine("Já está no máximo!");
        }

        public void DiminuirVelocidade(VentiladorTeto ventilador)
        {
            ventilador.State = new EstadoMedio();
        }    
    }
}
