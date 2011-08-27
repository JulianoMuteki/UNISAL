using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class ListaRandomica : OrdenarStrategy
    {
        public override void Ordenar(List<string> list)
        {
            Console.WriteLine("Lista Randomica");
            Random random = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int posicao = random.Next(0, list.Count);
                Console.WriteLine(list[posicao]);
            }
        }
    }
}
