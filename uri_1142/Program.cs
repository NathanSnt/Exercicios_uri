using System;

namespace uri_1142
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, soma = 1;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (soma % 4 == 0)
                        Console.WriteLine("PUM");
                    else
                        Console.Write($"{soma} ");
                    soma++;
                }
            }
        }
    }
}