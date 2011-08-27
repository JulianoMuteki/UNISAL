using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPadraoNBR plugAmericano = new PlugAmericano();
            plugAmericano.Conect();
            plugAmericano.Desconect();

            Console.ReadKey();
        }
    }
}
