using System;
using System.Globalization;

namespace uri_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorRecebido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0, nota100 = 0;
            double moeda1Real = 0, moeda50 = 0, moeda25 = 0, moeda10 = 0, moeda05 = 0, moeda01 = 0;

            double valorInt = Math.Truncate(valorRecebido);
            double valorDecimal = valorRecebido - valorInt;

            // Calcular cédulas
            nota100 = Math.Truncate(valorInt / 100);
            valorInt -= nota100 * 100;

            nota50 = Math.Truncate(valorInt / 50);
            valorInt -= nota50 * 50;

            nota20 = Math.Truncate(valorInt / 20);
            valorInt -= nota20 * 20;

            nota10 = Math.Truncate(valorInt / 10);
            valorInt -= nota10 * 10;

            nota5 = Math.Truncate(valorInt / 5);
            valorInt -= nota5 * 5;

            nota2 = Math.Truncate(valorInt / 2);
            valorInt -= nota2 * 2;

            moeda1Real = valorInt;

            // Calcular moedas
            if (valorDecimal >= 0.50)
            {
                moeda50 += 1;
                valorDecimal -= 0.50;
            }
            if (valorDecimal >= 0.25)
            {
                moeda25 += 1;
                valorDecimal -= 0.25;
            }
            while (valorDecimal >= 0.10)
            {
                moeda10 += 1;
                valorDecimal -= 0.10;
            }
            if (valorDecimal >= 0.05)
            {
                moeda05 += 1;
                valorDecimal -= 0.05;
            }
            while (valorDecimal >= 0.009)
            {
                moeda01 += 1;
                valorDecimal -= 0.01;
            }
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1Real} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda05} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
        }
    }
}
