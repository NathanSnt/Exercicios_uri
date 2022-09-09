using System;

namespace uri_1073
{
    class URI
    {

        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }
            }

        }

    }
}