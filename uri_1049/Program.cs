using System;

namespace uri_1049
{
    class URI
    {

        static void Main(string[] args)
        {
            string tip1 = Console.ReadLine();
            string tip2 = Console.ReadLine();
            string tip3 = Console.ReadLine();

            if (tip1 == "vertebrado")
            {
                if (tip2 == "ave")
                {
                    if (tip3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tip3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tip2 == "mamifero")
                {
                    if (tip3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tip3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (tip1 == "invertebrado")
            {
                if (tip2 == "inseto")
                {
                    if (tip3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tip3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tip2 == "anelideo")
                {
                    if (tip3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tip3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }

    }
}