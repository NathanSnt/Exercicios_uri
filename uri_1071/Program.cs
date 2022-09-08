using System;

namespace uri_1071
{
    class URI
    {

        static void Main(string[] args)
        {
            int soma = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (i != x && i != y)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i;
                        }
                    }
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i != x && i != y)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i;
                        }
                    }
                }
            }
            Console.WriteLine(soma);
        }

    }
}
