using System;
using System.Globalization;

namespace uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double novoSalario = 0, reajuste = 0, porcent = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (0 <= salario && salario <= 400.00)
            {
                porcent = 15;
            }
            else if (400.00 < salario && salario <= 800.00)
            {
                porcent = 12;
            }
            else if (800.00 < salario && salario <= 1200.00)
            {
                porcent = 10;
            }
            else if (1200.00 < salario && salario <= 2000.00)
            {
                porcent = 7;
            }
            else if (salario > 2000.00)
            {
                porcent = 4;
            }

            reajuste = salario * (porcent / 100);
            novoSalario = salario + reajuste;

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {porcent} %");
        }
    }
}