using System;

namespace uri_1131
{
    class URI
    {
        static void Main(string[] args)
        {
            int grenais = 0, inter, gremio, empates = 0, vitoriaInter = 0, vitoriaGremio = 0, opc = 0;
            string[] valores;

            while (true)
            {
                valores = Console.ReadLine().Split();
                inter = int.Parse(valores[0]);
                gremio = int.Parse(valores[1]);

                if (inter > gremio)
                {
                    vitoriaInter++;
                }
                else if (gremio > inter)
                {
                    vitoriaGremio++;
                }
                else
                {
                    empates++;
                }
                grenais++;

                while (true)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 2 || opc == 1) { break; }
                }
                if (opc == 2) { break; }
            }

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriaGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriaGremio > vitoriaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}