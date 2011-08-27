using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class VentiladorTeto
    {
        public IState State { get; set; }
    
        private string _local = string.Empty;

        public VentiladorTeto()
        {
            State = new EstadoDesligado();
            this.State = State;
            this._local = "Ventilador Sala";
        }

        public void AumentarVelocidade()
        {
            State.AumentarVelocidade(this);
            Console.WriteLine("{0} velocidade " + " " + State.Velocidade,_local);
        }

        public void DiminuirVelocidade()
        {
            State.DiminuirVelocidade(this);
            Console.WriteLine("{0} velocidade " + " " + State.Velocidade,_local);
        }
    }
}
