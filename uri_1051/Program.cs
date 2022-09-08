using System;
using System.Globalization;

namespace uri_1051
{
    class URI
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxa = 0;

            if (salario - 4500.00 > 0)
            {
                salario -= 4500.00;
                taxa = (salario * 0.28) + (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine($"R$ {taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario - 3000.00 > 0)
            {
                salario -= 3000;
                taxa = (salario * 0.18) + (1000 * 0.08);
                Console.WriteLine($"R$ {taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario - 2000 > 0)
            {
                salario -= 2000;
                taxa = salario * 0.08;
                Console.WriteLine($"R$ {taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Isento");
            }
        }
    }
}