using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class OrdenarLista
    {
        private List<string> _list = new List<string>();
        private OrdenarStrategy _ordenarStrategy;

        public void SetOrdenarStrategy(OrdenarStrategy ordenarStrategy)
        {
            this._ordenarStrategy = ordenarStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Ordenar()
        {
            _ordenarStrategy.Ordenar(_list);
            Console.WriteLine();
        }
    }
}
