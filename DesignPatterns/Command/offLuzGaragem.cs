using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
  public  class offLuzGaragem:ICommand
    {
        PortaEletronica _PortaEletronica;

        public offLuzGaragem(PortaEletronica portaEletronica)
        {
            portaEletronica._local = "Garagem";
            this._PortaEletronica = portaEletronica;
        }

        public void Executar()
        {
            this._PortaEletronica.DesligarLuz();
        }
    }
}
