using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class TomadaNBR
    {
        public void Conectar()
        {
            Console.WriteLine("Conectado!");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectado!");
        }
    }
}
