using System;

namespace uri_2006
{
    class URI
    {
        static void Main(string[] args)
        {
            string tipo = Console.ReadLine();
            string[] valores = Console.ReadLine().Split();

            int acertos = 0;

            for (int x = 0; x < 5; x++)
            {
                if (valores[x] == tipo)
                {
                    acertos++;
                }
            }
            Console.WriteLine(acertos);
        }
    }
}