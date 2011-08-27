using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class onPortaGaragem:ICommand
    {
        PortaEletronica _PortaEletronica;

        public onPortaGaragem(PortaEletronica portaEletronica)
        {
           portaEletronica._local = "Garagem";
            this._PortaEletronica = portaEletronica;
        }

        public void Executar()
        {
            this._PortaEletronica.Abrir();
        }
    }
}
