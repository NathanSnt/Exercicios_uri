using System;
using System.Globalization;

namespace uri_1079
{
    class URI
    {

        static void Main(string[] args)
        {
            double a, b, c, media;
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string[] valores = Console.ReadLine().Split();
                a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (a * 2 + b * 3 + c * 5) / 10;
                Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}