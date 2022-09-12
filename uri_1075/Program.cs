using System;

namespace uri_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if(i % x == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}