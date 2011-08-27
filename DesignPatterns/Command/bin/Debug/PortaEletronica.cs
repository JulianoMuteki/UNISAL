using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class PortaEletronica
    {
        public string _local = string.Empty;

        public PortaEletronica() { }

        public void Abrir()
        {
            Console.WriteLine("{0} porta aberta", _local);
        }

        public void Fechar()
        {
            Console.WriteLine("{0} porta fechada", _local);
        }

        public void LigarLuz()
        {
            Console.WriteLine("{0} luz ligada", _local);
        }

        public void DesligarLuz()
        {
            Console.WriteLine("{0} luz desligada", _local);
        }
    }
}
