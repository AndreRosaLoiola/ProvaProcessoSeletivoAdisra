using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec3
{
    public abstract class Carro
    {
        public string NumeroChassi { get; set; }
        public string NumeroMotor { get; set; }
        public double CustoProducao { get; set; }

        public Carro(string numeroChassi, string numeroMotor, double custoProducao)
        {
            NumeroChassi = numeroChassi;
            NumeroMotor = numeroMotor;
            CustoProducao = custoProducao;
        }

        public abstract double CalcularCustoVenda();
    }
}
