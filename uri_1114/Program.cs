using System;

namespace uri_1114
{
    class URI
    {
        static void Main(string[] args)
        {
            int teste = 0;
            while (true)
            {
                teste = int.Parse(Console.ReadLine());
                if (teste == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }

        }
    }
}