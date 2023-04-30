using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec3
{
    public class CarroDiesel : Carro
    {
        public double CapacidadeCarga { get; set; }
        public double VolumeCacamba { get; set; }

        public CarroDiesel(string numeroChassi, string numeroMotor, double custoProducao, double capacidadeCarga, double volumeCacamba)
            : base(numeroChassi, numeroMotor, custoProducao)
        {
            CapacidadeCarga = capacidadeCarga;
            VolumeCacamba = volumeCacamba;
        }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.3;
            double lucro = CustoProducao * 0.25;

            return CustoProducao + imposto + lucro;
        }
    }
}