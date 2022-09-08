using System;

namespace uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {

            int inicio, fim, duracao = 0;
            string[] valores = Console.ReadLine().Split();

            inicio = int.Parse(valores[0]);
            fim = int.Parse(valores[1]);

            if (inicio >= fim)
            {
                int x = inicio;
                if (x == fim)
                {
                    x += 1;
                    while (x != fim)
                    {
                        x += 1;
                        duracao += 1;
                        if (x == 24)
                        {
                            x = 0;
                        }
                        else if (x > 24)
                        {
                            x = 0;
                            duracao -= 1;
                        }
                    }
                    duracao += 1;
                }
                else
                {
                    while (x != fim)
                    {
                        x += 1;
                        duracao += 1;
                        if (x == 24)
                        {
                            x = 0;
                        }
                    }
                }
            }
            else if (fim > inicio)
            {
                duracao = fim - inicio;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}