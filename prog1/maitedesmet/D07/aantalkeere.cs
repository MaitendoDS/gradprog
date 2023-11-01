using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class aantalkeere
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst:");
            string input = Console.ReadLine();

            int aantalKeer = 0;

            foreach (char c in input) {
                if (c == 'e'| c=='E') {
                    aantalKeer++;
                }
            }
            Console.WriteLine($"De letter 'e' komt {aantalKeer} voor.");

        }
    }
}
