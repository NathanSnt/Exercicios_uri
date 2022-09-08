using System;

namespace uri_1065
{
    class URI
    {

        static void Main(string[] args)
        {
            double valor;
            int contador = 0;
            for (int x = 0; x < 5; x++)
            {
                valor = double.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"{contador} valores pares");

        }

    }
}
