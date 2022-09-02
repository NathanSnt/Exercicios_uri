using System;
using System.Globalization;

namespace uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split();
            string[] p2 = Console.ReadLine().Split();

            double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow((x1 - x2), 2.00) + Math.Pow((y1 - y2), 2.00));

            Console.WriteLine($"{distancia.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}
