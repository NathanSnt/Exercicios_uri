using System;

namespace uri_1134
{
    class URI
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0, opc;

            while (true)
            {
                opc = int.Parse(Console.ReadLine());

                if (opc == 1) { alcool++; }
                else if (opc == 2) { gasolina++; }
                else if (opc == 3) { diesel++; }
                else if (opc == 4) { break; }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}