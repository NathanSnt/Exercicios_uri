using System;

namespace uri_1072

{
    class URI
    {

        static void Main(string[] args)
        {

            int valor, dentro = 0, fora = 0;
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }

    }
}