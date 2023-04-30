using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec1
{
    public class Exercicio1
    {
        public List<int> GetFibonacciSequence(int inicio, int fim)
        {
            List<int> sequencia = new List<int>();

            if (inicio == 1)
            {
                sequencia.Add(1);
                sequencia.Add(2);
                inicio = 2;
            }

            int atual = inicio;
            int proximo = inicio + 1;

            while (proximo <= fim)
            {
                sequencia.Add(proximo);
                int temp = atual;
                atual = proximo;
                proximo = temp + proximo;
            }

            return sequencia;
        }
    }
}
