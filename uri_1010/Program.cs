using System;
using System.Globalization;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto1 = Console.ReadLine().Split();
            string[] produto2 = Console.ReadLine().Split();

            int cod1 = int.Parse(produto1[0]);
            int qtd1 = int.Parse(produto1[1]);
            double valor1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);

            int cod2 = int.Parse(produto2[0]);
            int qtd2 = int.Parse(produto2[1]);
            double valor2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);

            double prod1 = qtd1 * valor1;
            double prod2 = qtd2 * valor2;
            double tot = prod1 + prod2;

            Console.WriteLine($"VALOR A PAGAR: R$ {tot.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
