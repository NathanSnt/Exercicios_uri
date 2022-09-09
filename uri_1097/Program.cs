using System;

namespace uri_1097
{
    class URI
    {
        static void Main(string[] args)
        {
            int controle = 5;
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = controle+2; j >= controle; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
                controle += 2;
            }

        }
    }
}