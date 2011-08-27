using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class ListaOrdenada : OrdenarStrategy
    {
        public override void Ordenar(List<string> list)
        {
            Console.WriteLine("Lista Ordenada");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
