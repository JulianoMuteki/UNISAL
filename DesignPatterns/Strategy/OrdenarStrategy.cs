using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
   public abstract class OrdenarStrategy
    {
       public abstract void Ordenar(List<string> list);
    }
}
