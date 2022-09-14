using System;

namespace uri_1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y, N = 0, qtd = 0;

            while (true)
            {
                Y = int.Parse(Console.ReadLine());
                if (Y > X) { break; }
            }
            for (int i = X; i < Y; i++)
            {
                N += i;
                qtd++;
                if (N > Y) { break; }
            }
            Console.WriteLine(qtd);
        }
    }
}
