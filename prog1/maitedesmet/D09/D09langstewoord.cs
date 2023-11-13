using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09langstewoord
    {
        static void Main(string[] args)
        {
            Console.Write("geef een tekst: ");
            string tekst = Console.ReadLine();

            char[] seperators = { ' ', ',', '.', '!', '?' };

            string[] woorden = tekst.Split(seperators);

            int aantalWoorden = 0;
            string langsteWoord = "";
            
            foreach (string woord in woorden)
            {
                if (woord != "")
                {
                    aantalWoorden++;
                    if (woord.Length > langsteWoord.Length)
                    {
                        langsteWoord = woord;
                    }
                }
            }

            Console.WriteLine($"aantal woorden is {aantalWoorden}")langsteWoord;"
;            Console.WriteLine($"het langste woord is {langsteWoord}");
        }
    }
}
