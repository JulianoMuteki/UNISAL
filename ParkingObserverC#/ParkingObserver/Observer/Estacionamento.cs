using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingObserver.Observer
{
   public abstract class Estacionamento //class Stock
    {
        public string Symbol { get; set; }
        private int _numVagas;

        private List<ICarros> _carros = new List<ICarros>();

        // Constructor
        public Estacionamento(string symbol, int numVagas)
        {
            this.Symbol = symbol;
            this._numVagas = numVagas;
        }

        public void Attach(ICarros carro)
        {
            _carros.Add(carro);
        }

        public void Detach(ICarros carro)
        {
            _carros.Remove(carro);
        }

        public void MudarDeAndar(string nomeCarro, int novoAndar)
        {
            foreach (Carros car in _carros)
            {
                if (car.Nome == nomeCarro)
                {
                    car.Andar = novoAndar;
                }

            }
        }
        public void Notify()
        {
            foreach (ICarros carro in _carros)
            {
                carro.Update(this);
            }
            Console.WriteLine("");
        }

        // Gets or sets the price

        public int NumeroDeVagas
        {
            get { return _numVagas; }

            set
            {
                if (_numVagas != value)
                {
                    _numVagas = value;
                    Notify();
                }
            }
        }
    }
}
