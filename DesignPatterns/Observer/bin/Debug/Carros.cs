using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Carros : ICarros //class Investor
    {
        public string Nome { get; private set; }
        private int nAndar { get; set; }

        private EstacionamentoIguatemi _estacionamentoIguatemi;

        public Carros(EstacionamentoIguatemi estacionamentoIguatemi, string nome, int andar)
        {
            this.Nome = nome;
            this.nAndar = andar;
            this._estacionamentoIguatemi = estacionamentoIguatemi;
        }

        public int Numero_Andar
        {
            get { return nAndar; }

            set { nAndar = value; }
        }

        public void Update()
        {
            Console.WriteLine(_estacionamentoIguatemi.NomeEstacionamento
                + " " + Nome + " está no andar " + nAndar + " - " + "Vagas liberada em: QuadraX, CorredorY");
        }
    }
}
