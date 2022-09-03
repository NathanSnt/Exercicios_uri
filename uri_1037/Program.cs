using System;
using System.Globalization;

namespace usi_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0 && num <= 25.000000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num >= 25.00001 && num <= 50.000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (num >= 50.00001 && num <= 75.000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (num >= 75.00001 && num <= 100.000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}