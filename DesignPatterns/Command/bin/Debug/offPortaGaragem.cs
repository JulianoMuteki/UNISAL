using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class offPortaGaragem:ICommand
    {
        PortaEletronica _PortaEletronica;

        public offPortaGaragem(PortaEletronica portaEletronica)
        {
            portaEletronica._local = "Garagem";
            this._PortaEletronica = portaEletronica;
        }

        public void Executar()
        {
            this._PortaEletronica.Fechar();
        }
    }
}
