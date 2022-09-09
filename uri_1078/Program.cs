using System;

namespace uri_1078
{
    class URI
    {

        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {x} = {i * x}");
            }

        }

    }
}