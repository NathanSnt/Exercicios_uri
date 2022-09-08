using System;
using System.Collections.Generic;

namespace uri_1052
{
    class URI
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> meses = new Dictionary<int, string>()
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
                {5, "May" },
                {6, "June" },
                {7, "July" },
                {8, "August" },
                {9, "September" },
                {10, "October" },
                {11, "November" },
                {12, "December" }
            };

            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine(meses[mes]);

        }

    }
}