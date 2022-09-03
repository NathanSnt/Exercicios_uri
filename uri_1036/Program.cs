using System;
using System.Globalization;

namespace uri_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (a == 0 || b == 0 || c == 0 || b < c)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                double raiz = Math.Sqrt(delta);
                double raizA = ((-(b)) + raiz) / (2 * a);
                double raizB = ((-(b)) - raiz) / (2 * a);

                Console.WriteLine($"R1 = {raizA.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {raizB.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}