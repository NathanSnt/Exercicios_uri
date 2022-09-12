using System;

namespace uri_1115
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            int x, y;
            while (true)
            {
                valores = Console.ReadLine().Split();
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }

        }
    }
}