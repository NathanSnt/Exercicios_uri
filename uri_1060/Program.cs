using System;

namespace uri_1060
{
    class URI
    {

        static void Main(string[] args)
        {
            double valor;
            int contador = 0;
            for (int x = 0; x < 6; x++)
            {
                valor = double.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"{contador} valores positivos");

        }

    }
}
