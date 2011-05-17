using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingObserver.Observer
{
    class EstacionamentoIguatemi: Estacionamento
    {
        public EstacionamentoIguatemi(string symbol, int numVagas)
            : base(symbol, numVagas)
        {
        }
    }
}
