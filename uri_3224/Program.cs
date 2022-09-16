using System;

namespace uri_3224
{
    class URI
    {
        static void Main(string[] args)
        {
            string ahDoJon, ahDoMedico;
            ahDoJon = Console.ReadLine();
            ahDoMedico = Console.ReadLine();

            if (ahDoJon.Length >= ahDoMedico.Length)
            {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}