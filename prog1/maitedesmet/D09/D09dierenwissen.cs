using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09dierenwissen
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            do
            {
                foreach (string dier in boerderijDieren)
                {
                    if (dier == null)
                    {
                        Console.Write("gewist");
                    } else
                    {
                        Console.Write(dier + " ");

                    }
                }
                Console.WriteLine();

                Console.Write("welk dier wil je verwijderen?: ");
                string teWissenDier = Console.ReadLine();
                int index = Array.IndexOf(boerderijDieren, teWissenDier);

                if (index != -1)
                {
                    boerderijDieren[index] = null;
                }
            } while (true);

        }
    }
}
