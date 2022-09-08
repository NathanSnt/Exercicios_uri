using System;

namespace uri_1066
{
    class URI
    {

        static void Main(string[] args)
        {
            double valor;
            int pares = 0, impares = 0, positivos = 0, negativos = 0;
            for (int x = 0; x < 5; x++)
            {
                valor = double.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }
            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
            Console.WriteLine(0 % 2);
        }

    }
}
