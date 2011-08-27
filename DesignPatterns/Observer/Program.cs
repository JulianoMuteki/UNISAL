using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacionamentoIguatemi estIguatemi = new EstacionamentoIguatemi("Iguetemi Parking", 120);
            estIguatemi.InserirCarro(new Carros(estIguatemi, "Carro1", 2));
            estIguatemi.InserirCarro(new Carros(estIguatemi, "Carro2", 3));

            estIguatemi.Notificar();
            estIguatemi.NumeroDeVagas = 119;

            estIguatemi.MudarDeAndar("Carro1", 5);
            estIguatemi.Notificar();

            Console.ReadKey();
        }
    }
}
