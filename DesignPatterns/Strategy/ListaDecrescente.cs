using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class ListaDecrescente : OrdenarStrategy
    {
        public override void Ordenar(List<string> list)
        {
            Console.WriteLine("Lista Decrescente");
            for (int i = list.Count; i > 0; i--)
            {
                Console.WriteLine(list[i-1]);
            }
        }
    }
}
