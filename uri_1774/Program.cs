using System;

namespace uri_1774
{
    class Program
    {
        static void Main(string[] args)
        {
            int roteadores, cabo, R1, R2, valorCabo, custoTot = 0, custo = 10000;
            string[] valores, infos;

            valores = Console.ReadLine().Split();

            roteadores = int.Parse(valores[0]);
            cabo = int.Parse(valores[1]);

            for (int i = 0; i < cabo; i++)
            {
                infos = Console.ReadLine().Split();
                for (int r = 1; r <= roteadores; r++)
                {

                    R1 = int.Parse(infos[0]);
                    R2 = int.Parse(infos[1]);
                    valorCabo = int.Parse(infos[2]);
                    if (r == R1)
                    {
                        if (valorCabo < custo)
                        {
                            custo = valorCabo;
                        }
                    }
                    else
                    {
                        custo = 10000;
                        custoTot += custo;
                    }
                }
            }
            Console.WriteLine(custoTot);
        }
    }
}
