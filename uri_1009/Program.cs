using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = vendas * 0.15;
            salario += comissao;

            Console.WriteLine($"TOTAL = R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
