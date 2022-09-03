using System;
using System.Globalization;

namespace uri_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (a + b > c && b + c > a && c + a > b)
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double area = ((a + b) / 2) * c;
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}