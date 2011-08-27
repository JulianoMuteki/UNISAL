using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Command
{
    public class ControleRemoto
    {
        private IList<ICommand> _onComando;

        private IList<ICommand> _offComando;

        public ControleRemoto()
        {
            _onComando = new ICommand[4];
            _offComando = new ICommand[4];

            ICommand semComando = new SemComando();

            for (int i = 0; i < 4; i++)
            {
                _onComando[i] = semComando;
                _offComando[i] = semComando;
            }
        }

        public void SetaComando(int slot, ICommand onComando, ICommand offComado)
        {
            _onComando[slot] = onComando;
            _offComando[slot] = offComado;
        }

        public void OnPressionado(int slot)
        {
            _onComando[slot].Executar();
        }

        public void OffPressionado(int slot)
        {
            _offComando[slot].Executar();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}
