using System;
using System.Globalization;

namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;
            double pesos = pesoA + pesoB + pesoC;

            // double media = ((a * pesoA) + (b * pesoB) + (c * pesoC)) / pesos;

            double somaPesos = pesoA + pesoB + pesoC;
            double somaNotas = a * pesoA + b * pesoB + c * pesoC;
            double media = somaNotas / somaPesos;

            Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
