using System;
using System.Globalization;

namespace uri_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorRecebido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = valorRecebido;
            int nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0, nota100 = 0;
            int moeda1Real = 0, moeda50 = 0, moeda25 = 0, moeda10 = 0, moeda5 = 0, moeda1 = 0;

            while (valor > 0)
            {
                if (valor - 100 >= 0)
                {
                    valor -= 100;
                    nota100 += 1;
                }
                else if (valor - 50 >= 0)
                {
                    valor -= 50;
                    nota50 += 1;
                }
                else if (valor - 20 >= 0)
                {
                    valor -= 20;
                    nota20 += 1;
                }
                else if (valor - 10 >= 0)
                {
                    valor -= 10;
                    nota10 += 1;
                }
                else if (valor - 5 >= 0)
                {
                    valor -= 5;
                    nota5 += 1;
                }
                else if (valor - 2 >= 0)
                {
                    valor -= 2;
                    nota2 += 1;
                }
                else if (valor - 1 >= 0)
                {
                    valor -= 1;
                    moeda1Real += 1;
                }
                else if (valor - 0.50 >= 0)
                {
                    valor -= 0.50 ;
                    moeda50 += 1;
                }
                else if (valor - 0.25 >= 0)
                {
                    valor -= 0.25;
                    moeda25 += 1;
                }
                else if (valor - 0.10 >= 0)
                {
                    valor -= 0.10;
                    moeda10 += 1;
                }
                else if (valor - 0.05 >= 0)
                {
                    valor -= 0.05;
                    moeda5 += 1;
                }
                else if (valor - 0.01 >= 0)
                {
                    valor -= 0.01;
                    moeda1 += 1;
                }
                else
                {
                    valor = 0;
                }
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
            Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 0.01");
        }
    }
}
