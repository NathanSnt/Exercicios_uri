using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
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
            }

        }
    }
}
