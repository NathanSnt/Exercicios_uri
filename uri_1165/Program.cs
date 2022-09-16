using System;

namespace uri_1165
{
    class URI
    {
        static void Main(string[] args)
        {
            int N, X, Y;

            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                Y = 0;
                for (int j = X-1; j > 0; j--)
                {
                    if (X % j == 0)
                    {
                        Y++;
                    }
                }
                Console.WriteLine((Y > 1)? $"{X} nao eh primo" : $"{X} eh primo");
            }
        }
    }
}