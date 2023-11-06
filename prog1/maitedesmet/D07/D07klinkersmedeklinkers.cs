using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07klinkersmedeklinkers
    {
        static void Main(string[] args)
        {
            string klinkers = "aeiou";
            string medeklinkers = "bcdfghjklmnpqrstvwyz";

           
            Console.WriteLine("geef een tekst: ");
            string input = Console.ReadLine();

            int positie = 0;

            
            int aantalKlinkers = 0;
            int aantalMedelinkers = 0;

            foreach (char c in input) {
                if (klinkers.Contains(c)) { aantalKlinkers++; }
                else if (medeklinkers.Contains(c))
                {
                    aantalMedelinkers++;
                }
             
            }
            Console.WriteLine($"er zijn {aantalKlinkers} klinkers en {aantalMedelinkers} medeklinkers.");

        }
    }
}
