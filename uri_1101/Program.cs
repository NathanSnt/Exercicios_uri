using System;

namespace uri_1101
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            int M = 1, N = 1, soma = 0;
            while (M > 0 && N > 0)
            {
                valores = Console.ReadLine().Split();
                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);
                if (M <= 0 || N <= 0) { break; }
                if (M >= N)
                {
                    for (int i = N; i <= M; i++)
                    {
                        Console.Write($"{i} ");
                        soma += i;
                    }
                    Console.WriteLine($"Sum={soma}");
                }
                else
                {
                    for (int i = M; i <= N; i++)
                    {
                        Console.Write($"{i} ");
                        soma += i;
                    }
                    Console.WriteLine($"Sum={soma}");
                }
                soma = 0;
            }

        }
    }
}