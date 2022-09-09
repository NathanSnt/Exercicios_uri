using System;
using System.Globalization;

namespace uri_1116
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            double x, y;
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                valores = Console.ReadLine().Split();
                x = double.Parse(valores[0]);
                y = double.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine($"{(x / y).ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }

        }
    }
}