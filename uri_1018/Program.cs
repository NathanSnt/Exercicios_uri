using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor: R$ {valor},00");
            int nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0, nota100 = 0;

            while (valor != 0)
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
                    nota1 += 1;
                }
            }
            Console.WriteLine($"{nota100} notas de R$ 100,00");
            Console.WriteLine($"{nota50} notas de R$ 50,00");
            Console.WriteLine($"{nota20} notas de R$ 20,00");
            Console.WriteLine($"{nota10} notas de R$ 10,00");
            Console.WriteLine($"{nota5} notas de R$ 5,00");
            Console.WriteLine($"{nota2} notas de R$ 2,00");
            Console.WriteLine($"{nota1} notas de R$ 1,00");
        }
    }
}
