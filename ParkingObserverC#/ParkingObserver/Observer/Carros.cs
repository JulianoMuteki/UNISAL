using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingObserver.Observer
{
    public class Carros : ICarros //class Investor
    {
        public string Nome { get; set; }
        public int Andar { get; set; }

        //Construtor
        public Carros(string nome, int andar)
        {
            this.Nome = nome;
            this.Andar = andar;
        }

        public void Update(Estacionamento estacionamento)
        {
            Console.WriteLine(estacionamento.Symbol + " " + Nome + " está no andar " + Andar + " - " + "Vagas liberada em: QuadraX, CorredorY");
        }

        //Gets or sets the Estacionamento
       // private Estacionamento Estacionamento { get; set; }

    }
}
