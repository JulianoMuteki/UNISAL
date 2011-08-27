using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdenarLista gravarEstudantes = new OrdenarLista();

            gravarEstudantes.Add("Samual");
            gravarEstudantes.Add("Jimmy");
            gravarEstudantes.Add("Sandra");
            gravarEstudantes.Add("Vivek");
            gravarEstudantes.Add("Anna");

            gravarEstudantes.SetOrdenarStrategy(new ListaOrdenada());
            gravarEstudantes.Ordenar();

            gravarEstudantes.SetOrdenarStrategy(new ListaRandomica());
            gravarEstudantes.Ordenar();

            gravarEstudantes.SetOrdenarStrategy(new ListaDecrescente());
            gravarEstudantes.Ordenar();

            Console.ReadKey();
        }
    }
}
