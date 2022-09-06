using System;

namespace uri_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            //int meio = 0;
            //int maior = Math.Max(Math.Max(int.Parse(valores[0]), int.Parse(valores[1])), int.Parse(valores[2]));
            //int menor = Math.Min(Math.Min(int.Parse(valores[0]), int.Parse(valores[1])), int.Parse(valores[2]));
            int meio, maior, menor;
            meio = maior = menor = int.Parse(valores[0]);
            for (int x = 0; x < 3; x++)
            {
                if (int.Parse(valores[x]) > maior)
                {
                    maior = int.Parse(valores[x]);
                }
                else if (int.Parse(valores[x]) < menor)
                {
                    menor = int.Parse(valores[x]);
                }
                else
                {
                    meio = int.Parse(valores[x]);
                }
            }

            /*
            for (int x = 0; x < 3; x++)
            {
                if (int.Parse(valores[x]) != maior && int.Parse(valores[x]) != menor)
                {
                    meio = int.Parse(valores[x]);
                    break;
                }
                else if (int.Parse(valores[x]) >= meio)
                {
                    meio = int.Parse(valores[x]);
                }
            }
            */
            Console.WriteLine($"{menor}\n{meio}\n{maior}\n");

            foreach (string valor in valores)
            {
                Console.WriteLine(valor);
            }
        }
    }
}