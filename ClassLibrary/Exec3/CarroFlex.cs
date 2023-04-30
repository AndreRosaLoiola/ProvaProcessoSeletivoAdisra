using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec3
{
    public class CarroFlex : Carro
    {
        public int NumeroPortas { get; set; }
        public double Cilindrada { get; set; }

        public CarroFlex(string numeroChassi, string numeroMotor, double custoProducao, int numeroPortas, double cilindrada)
            : base(numeroChassi, numeroMotor, custoProducao)
        {
            NumeroPortas = numeroPortas;
            Cilindrada = cilindrada;
        }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.2;
            double lucro = CustoProducao * 0.25;

            return CustoProducao + imposto + lucro;
        }
    }
}
