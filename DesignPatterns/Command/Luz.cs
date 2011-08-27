using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class Luz
    {
        public string Local = string.Empty;

        public Luz() { }

        public void Ligar()
        {
            Console.WriteLine("{0} luz ligada", Local);
        }

        public void Desligar()
        {
            Console.WriteLine("{0} luz desligada", Local);
        }
    }
}
