using System;

namespace uri_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);
            int y = 1;

            while (y <= Y)
            {
                for (int j = 0; j < X; j++)
                {
                    Console.Write($"{y}" + (j == X - 1? "" : " "));
                    y++;
                }
                Console.WriteLine();
            }
        }
    }
}
