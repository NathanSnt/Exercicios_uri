using System;

namespace uri_1143
{
    class URI
    {
        static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                x = i;
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine($"{x}");
                    }
                    else
                    {
                        Console.Write($"{x} ");
                    }
                    x *= i;
                }

                x = i;
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine($"{x + 1}");
                    }
                    else if (j == 1)
                    {
                        Console.Write($"{x + 1} ");
                    }
                    else
                    {
                        Console.Write($"{x} ");
                    }
                    x *= i;
                }
            }
        }
    }
}