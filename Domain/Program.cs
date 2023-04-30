using ClassLibrary.Exec1;
using ClassLibrary.Exec2;
using ClassLibrary.Exec3;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {



            // Calcula a largura do console
            int largura = Console.WindowWidth;
            //Dividimos a largura por 2 para obter a posição central horizontal do console
            //, e adicionamos 14 para
            //compensar o tamanho da moldura (borda) que estamos usando,
            //que tem 14 caracteres de largura.

            Console.Clear();
            Console.WriteLine("╔═════════════════════════════╗".PadLeft(largura / 2 + 14)); ;
            Console.WriteLine("║        Menu principal       ║".PadLeft(largura / 2 + 14));
            Console.WriteLine("╠═════════════════════════════╣".PadLeft(largura / 2 + 14));
            Console.WriteLine("║ 1 - Sequência Fibonacci     ║".PadLeft(largura / 2 + 14));
            Console.WriteLine("║ 2 - Matriz De Números Pares ║".PadLeft(largura / 2 + 14));
            Console.WriteLine("║ 3 - Fabrica Automoveis      ║".PadLeft(largura / 2 + 14));
            Console.WriteLine("║ 4 - Sair                    ║".PadLeft(largura / 2 + 14));
            Console.WriteLine("╚═════════════════════════════╝".PadLeft(largura / 2 + 14));

            Console.Write("Digite sua opção: ");
            int opcaoPrincipal = int.Parse(Console.ReadLine());

            if (opcaoPrincipal == 1)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Digite o número inicial da sequência Fibonacci: ");
                    int inicio = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o número final da sequência Fibonacci: ");
                    int fim = Convert.ToInt32(Console.ReadLine());

                    Exercicio1 exce = new Exercicio1();
                    List<int> sequence = exce.GetFibonacciSequence(inicio, fim);

                    Console.Write("Sequência Fibonacci entre " + inicio + " e " + fim + ": ");
                    foreach (int num in sequence)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine(); // Quebra de linha após a impressão da sequência
                    Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════");
                    Console.WriteLine("Digite 's' para ver a sequência novamente ou qualquer outra tecla" +
                        " para voltar ao menu principal: ");
                    string resposta = Console.ReadLine();

                    if (resposta.ToLower() != "s")
                    {
                        break; // Sai do loop e volta ao menu principal
                    }
                    Console.Clear();

                }
            }
            else if (opcaoPrincipal == 2)
            {
                while (true)
                {
                    Exercicio2 exce2 = new Exercicio2();

                    Console.Write("Digite o número de linhas da matriz: ");
                    int linhas = int.Parse(Console.ReadLine());

                    Console.Write("Digite o número de colunas da matriz: ");
                    int colunas = int.Parse(Console.ReadLine());

                    int[,] matriz = new int[linhas, colunas];

                    for (int i = 0; i < linhas; i++)
                    {
                        for (int j = 0; j < colunas; j++)
                        {
                            Console.Write("Digite o valor da posição [{0},{1}]: ", i, j);
                            matriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    string maiorOcorrencia = exce2.ContarMaioresOcorrencias(matriz, linhas, colunas);

                    Console.WriteLine(maiorOcorrencia);

                    Console.WriteLine("Digite 's' para executar novamente ou qualquer outra tecla" +
                        " para voltar ao menu principal: ");
                    string resposta = Console.ReadLine();

                    if (resposta.ToLower() != "s")
                    {
                        break; // Sai do loop e volta ao menu principal
                    }
                    Console.Clear();
                }
            }
            else if (opcaoPrincipal == 3)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("╔═════════════════════════════╗".PadLeft(largura / 2 + 14));
                    Console.WriteLine("║       Menu da opção 3       ║".PadLeft(largura / 2 + 14));
                    Console.WriteLine("╠═════════════════════════════╣".PadLeft(largura / 2 + 14));
                    Console.WriteLine("║ 1 - Carro Flex              ║".PadLeft(largura / 2 + 14));
                    Console.WriteLine("║ 2 - Carro Diesel            ║".PadLeft(largura / 2 + 14));
                    Console.WriteLine("║ 3 - Carro Eletrico          ║".PadLeft(largura / 2 + 14));
                    Console.WriteLine("║ 4 - Voltar para o menu      ║".PadLeft(largura / 2 + 14));
                    Console.WriteLine("╚═════════════════════════════╝".PadLeft(largura / 2 + 14));

                    Console.Write("Digite sua opção: ");
                    int opcaoOpcao3 = int.Parse(Console.ReadLine());

                    if (opcaoOpcao3 == 1)
                    {
                        Console.WriteLine("Insira os dados do carro flex:");
                        Console.Write("Número do chassi: ");
                        string numeroChassi = Console.ReadLine();
                        Console.Write("Número do motor: ");
                        string numeroMotor = Console.ReadLine();
                        Console.Write("Número de portas: ");
                        int numeroPortas = int.Parse(Console.ReadLine());
                        Console.Write("Cilindrada: ");
                        double cilindrada = double.Parse(Console.ReadLine());
                        Console.Write("Custo de produção: ");
                        double custoProducao = double.Parse(Console.ReadLine());

                        CarroFlex carroFlex = new CarroFlex(numeroChassi, numeroMotor, custoProducao, numeroPortas, cilindrada);

                        double custoVenda = carroFlex.CalcularCustoVenda();

                        Console.WriteLine($"O custo de venda do carro flex é {custoVenda:C}.");

                        

                        Console.WriteLine("Digite 's' para executar novamente ou qualquer outra tecla" +
                        " para voltar ao menu principal: ");
                        string resposta = Console.ReadLine();

                        if (resposta.ToLower() != "s")
                        {
                            break; // Sai do loop e volta ao menu principal
                        }
                        Console.Clear();

                    }
                    else if (opcaoOpcao3 == 2)
                    {
                        Console.WriteLine("Insira os dados do carro diesel:");
                        Console.Write("Número do chassi: ");
                        string numeroChassi = Console.ReadLine();
                        Console.Write("Número do motor: ");
                        string numeroMotor = Console.ReadLine();
                        Console.Write("Capacidade de carga: ");
                        double capacidadeCarga = double.Parse(Console.ReadLine());
                        Console.Write("Volume da caçamba: ");
                        double volumeCacamba = double.Parse(Console.ReadLine());
                        Console.Write("Custo de produção: ");
                        double custoProducao = double.Parse(Console.ReadLine());

                        CarroDiesel carroDiesel = new CarroDiesel(numeroChassi, numeroMotor, custoProducao, capacidadeCarga, volumeCacamba);

                        double custoVenda = carroDiesel.CalcularCustoVenda();

                        Console.WriteLine($"O custo de venda do carro diesel é {custoVenda:C}.");

                        

                        Console.WriteLine("Digite 's' para executar novamente ou qualquer outra tecla" +
                        " para voltar ao menu principal: ");
                        string resposta = Console.ReadLine();

                        if (resposta.ToLower() != "s")
                        {
                            break; // Sai do loop e volta ao menu principal
                        }
                        Console.Clear();

                    }
                    else if (opcaoOpcao3 == 3)
                    {
                        Console.WriteLine("Insira os dados do carro elétrico:");
                        Console.Write("Número do chassi: ");
                        string numeroChassi = Console.ReadLine();
                        Console.Write("Número do motor: ");
                        string numeroMotor = Console.ReadLine();
                        Console.Write("Potência: ");
                        int potencia = int.Parse(Console.ReadLine());
                        Console.Write("Duração da bateria: ");
                        double duracaoBateria = double.Parse(Console.ReadLine());
                        Console.Write("Custo de produção: ");
                        double custoProducao = double.Parse(Console.ReadLine());

                        CarroEletrico carroEletrico = new CarroEletrico(numeroChassi, numeroMotor, custoProducao, potencia, duracaoBateria);

                        double custoVenda = carroEletrico.CalcularCustoVenda();

                        Console.WriteLine($"O custo de venda do carro elétrico é {custoVenda:C}.");
                        

                        Console.WriteLine("Digite 's' para executar novamente ou qualquer outra tecla" +
                        " para voltar ao menu principal: ");
                        string resposta = Console.ReadLine();

                        if (resposta.ToLower() != "s")
                        {
                            break; // Sai do loop e volta ao menu principal
                        }
                        Console.Clear();
                    }


                    else if (opcaoOpcao3 == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                    }
                }


            }


            else if (opcaoPrincipal == 4)
            {
                Console.Clear();

                Console.WriteLine("╔════════════════════════════════════════════════════╗".PadLeft(largura / 2 + 14));
                Console.WriteLine("║                 Obrigado por usar meu              ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║                 programa. Até a próxima!           ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║                                                    ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║    André Rosa Loiola                               ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║    E-mail: andre.kof@hotmail.com                   ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║    Whatsapp : (61) 98119-4732                      ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("║                                                    ║".PadLeft(largura / 2 + 14));
                Console.WriteLine("╚════════════════════════════════════════════════════╝".PadLeft(largura / 2 + 14));


                Environment.Exit(0);

            }





        }
    }
}