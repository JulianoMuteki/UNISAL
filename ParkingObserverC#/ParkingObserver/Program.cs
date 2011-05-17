using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkingObserver.Observer;

namespace ParkingObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estIguatemi = new EstacionamentoIguatemi("Iguetemi Parking", 120);
            estIguatemi.Attach(new Carros("Carro1", 1));
            estIguatemi.Attach(new Carros("Carro2", 2));

            estIguatemi.NumeroDeVagas = 121;
            estIguatemi.NumeroDeVagas = 125;

            estIguatemi.MudarDeAndar("Carro1", 5);

            estIguatemi.NumeroDeVagas = 200;

            Console.ReadKey();
        }
    }
}
