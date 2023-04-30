using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exec2
{
    public class Exercicio2
    {
        public string ContarMaioresOcorrencias(int[,] matriz, int linhas, int colunas)
        {
            int numPares = 0;
            int numImpares = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] % 2 == 0) // se o número é par
                    {
                        numPares++;
                    }
                    else // caso contrário (ímpar)
                    {
                        numImpares++;
                    }
                }
            }

            if (numPares > numImpares)
            {
                return string.Format("A maior ocorrência é de números pares, com {0} ocorrências.", numPares);
            }
            else if (numPares < numImpares)
            {
                return string.Format("A maior ocorrência é de números ímpares, com {0} ocorrências.", numImpares);
            }
            else // em caso de empate
            {
                return "A quantidade de números pares e ímpares é igual.";
            }
        }
    }
}
