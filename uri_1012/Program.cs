using System;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0], System.Globalization.CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], System.Globalization.CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine($"TRIANGULO: {(a * c / 2).ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {(3.14159 * Math.Pow(c, 2)).ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {((a + b) * c / 2).ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {(Math.Pow(b, 2)).ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {(a * b).ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
