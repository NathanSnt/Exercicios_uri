using System;

namespace uri_1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int aux = 0, fibo = 1, nextfibo = 1;
            Console.Write("0 ");
            for (int i = 0; i < N - 1; i++)
            {
                Console.Write($"{fibo}" + (i == N - 2? "\n" : " "));
                nextfibo = aux + fibo;
                aux = fibo;
                fibo = nextfibo;
            }
        }
    }
}
