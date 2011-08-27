using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
   public class PlugAmericano:IPadraoNBR
    {
       public string Nome { get; set; }
       private TomadaNBR _tomadaNBR;

       public PlugAmericano()
       {
           _tomadaNBR = new TomadaNBR();
           this.Nome = "Adaptador de tomada.";
       }
        
       public void Conect()
        {
            _tomadaNBR.Desconectar();
        }

        public void Desconect()
        {
            _tomadaNBR.Conectar();
        }
    }
}
