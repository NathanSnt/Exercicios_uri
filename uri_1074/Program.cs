using System;
using System.Security.Cryptography.X509Certificates;

namespace uri_1074
{
    class URI
    {

        static void Main(string[] args)
        {
            int valor;
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    if (valor % 2 == 0)
                    {
                        Console.Write("EVEN ");
                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (valor > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
            }

        }
    }
}