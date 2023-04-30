using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec3
{
    public class CarroEletrico : Carro
    {
        public double Potencia { get; set; }
        public double DuracaoBateria { get; set; }

        public CarroEletrico(string numeroChassi, string numeroMotor, double custoProducao, double potencia, double duracaoBateria)
            : base(numeroChassi, numeroMotor, custoProducao)
        {
            Potencia = potencia;
            DuracaoBateria = duracaoBateria;
        }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.1;
            double lucro = CustoProducao * 0.25;

            return CustoProducao + imposto + lucro;
        }
    }
    }
