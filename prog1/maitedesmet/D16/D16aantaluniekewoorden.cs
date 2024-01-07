using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16aantaluniekewoorden
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een tekst");
            string tekst = Console.ReadLine().ToLower();

            List<string> woorden = tekst.Split(',', ' ', '.', '!', '?').ToList();

            woorden.Remove("");
            woorden.Distinct();
            woorden.Sort();

            Console.WriteLine($"er zijn {woorden.Count} woorden:");
            Console.Write("alfabetisch:");

            for (int i = 0; i < woorden.Count; i++)
            {
                Console.Write(woorden[i]+" ");

            }
        }



    }
}
