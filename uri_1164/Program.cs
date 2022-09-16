using System;

namespace uri_1164
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, X, soma;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                soma = 0;
                for (int j = X-1; j > 0; j--)
                {
                    if (X % j == 0)
                    {
                        soma += j;
                    }

                }
                Console.WriteLine((soma == X)? $"{X} eh perfeito" : $"{X} nao eh perfeito");
            }
        }
    }
}