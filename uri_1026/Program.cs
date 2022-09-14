using System;

namespace uri_1026
{
    class URI
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    string[] valores = Console.ReadLine().Split();
                    UInt32 a = uint.Parse(valores[0]);
                    UInt32 b = uint.Parse(valores[1]);
                    Console.WriteLine(a ^ b);
                }
                catch (Exception EndOfStreamException)
                {
                    break;
                }
            }
        }
    }
}