using System;

namespace uri_1158
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, X, Y, soma;
            string[] valores;

            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                valores = Console.ReadLine().Split();
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
                soma = 0;
                for (int j = X; j < (X + Y * 2); j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}