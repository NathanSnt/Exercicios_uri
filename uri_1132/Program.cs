using System;

namespace uri_1132
{
    class URI
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x >= y)
            {
                for (int i = y; i <=  x; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }

            Console.WriteLine(soma);
        }
    }
}
