using System;
using System.Globalization;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabela = new string[5, 3] 
            { 
                { "1", "Cachorro Quente", "4.00" }, 
                { "2", "X-Salada", "4.50" }, 
                { "3", "X-Bacon", "5.00" }, 
                { "4", "Torrada simples", "2.00" }, 
                { "5", "Refrigerante", "1.50" } 
            };

            string[] pedido = Console.ReadLine().Split();
            int produto = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);
            switch (produto)
            {
                case 1:
                    Console.WriteLine($"Total: R$ {(double.Parse(tabela[0, 2], CultureInfo.InvariantCulture) * quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    Console.WriteLine($"Total: R$ {(double.Parse(tabela[1, 2], CultureInfo.InvariantCulture) * quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
                    break ;
                case 3:
                    Console.WriteLine($"Total: R$ {(double.Parse(tabela[2, 2], CultureInfo.InvariantCulture) * quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    Console.WriteLine($"Total: R$ {(double.Parse(tabela[3, 2], CultureInfo.InvariantCulture) * quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    Console.WriteLine($"Total: R$ {(double.Parse(tabela[4, 2], CultureInfo.InvariantCulture) * quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
            }

        }
    }
}