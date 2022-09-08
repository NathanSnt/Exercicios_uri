using System;

namespace uri_1070
{
    class URI
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            for (int i = x; i <= x+11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}