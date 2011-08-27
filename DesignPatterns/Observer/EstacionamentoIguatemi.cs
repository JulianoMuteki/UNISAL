using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class EstacionamentoIguatemi : Estacionamento
    {
        public string NomeEstacionamento { get; private set; }
        private int _numVagas;

        public EstacionamentoIguatemi(string nomeEstacionamento, int numVagas)
            : base()
        {
            this.NomeEstacionamento = nomeEstacionamento;
            this._numVagas = numVagas;
        }

        public int NumeroDeVagas
        {
            get { return _numVagas; }

            set
            {
                if (_numVagas != value)
                {
                    _numVagas = value;
                    Notificar();
                }
            }
        }

        public void MudarDeAndar(string nomeCarro, int novoAndar)
        {
            foreach (Carros car in RetornaListaCarros())
            {
                if (car.Nome == nomeCarro)
                {
                    car.Numero_Andar = novoAndar;
                }
            }
        }
    }
}
