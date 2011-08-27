using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
  public class onLuzSala: ICommand
 {
     Luz _luz;

     public onLuzSala(Luz luz)
     {
         luz.Local = "Sala";
         this._luz = luz;
     }

     public void Executar()
     {
         this._luz.Ligar();
     }
 }
}
