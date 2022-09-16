using System;

namespace uri_1159
{
    class URI
    {
        static void Main(string[] args)
        {
            int X, soma;
            while (true)
            {
                X = int.Parse(Console.ReadLine());
                if (X == 0) { break; }
                soma = 0;
                for (int i = X; i < X + 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += i;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}