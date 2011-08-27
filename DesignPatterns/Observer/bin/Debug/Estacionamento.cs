using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public abstract class Estacionamento
    {
        private List<ICarros> _carros = new List<ICarros>();

        public void InserirCarro(ICarros carro)
        {
            _carros.Add(carro);
        }

        public void RemoverCarro(ICarros carro)
        {
            _carros.Remove(carro);
        }

        public IList<ICarros> RetornaListaCarros()
        {
            return _carros;
        }

        public void Notificar()
        {
            foreach (ICarros carro in _carros)
            {
                carro.Update();
            }
            Console.WriteLine("");
        }
    }
}
