using System;
using System.Globalization;
using System.Collections.Generic;

namespace uri_1174
{
    class URI
    {
        static void Main(string[] args)
        {
            List<double> A = new List<double>();

            for (int i = 0; i < 100; i++)
            {
                A.Add(double.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < 100; i++)
            {
                if (A[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {A[i].ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}