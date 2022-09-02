using System;

namespace uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int ano, mes, dia;

            ano = idade / 365;
            idade -= ano * 365;

            mes = idade / 30;
            idade -= mes * 30;

            dia = idade;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
