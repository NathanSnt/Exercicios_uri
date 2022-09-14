using System;

namespace uri_1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            while (true)
            {
                X = int.Parse(Console.ReadLine());
                if (X == 0) { break; }
                for (int i = 1; i <= X; i++)
                {
                    Console.Write($"{i}" + (i == X? "\n" : " "));
                }
            }

        }
    }
}
