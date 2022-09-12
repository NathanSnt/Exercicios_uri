using System;

namespace uri_1080
{
    class URI
    {

        static void Main(string[] args)
        {

            int valor, maior = 0, posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor > maior)
                {
                    maior = valor;
                    posicao = i;
                }
            }
            Console.WriteLine($"{maior}\n{posicao}");
        }

    }
}