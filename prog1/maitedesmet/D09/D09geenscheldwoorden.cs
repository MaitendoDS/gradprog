using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09geenscheldwoorden
    {
        static void Main(string[] args)
        {
            
            string[] scheldwoorden = { "kamelenneuker", "kaashoer", "kankernicht", "foefkop", "erwtenteller", "aambeienlikker" };

            Console.Write("Geef een tekst : ");
            string tekst = Console.ReadLine();
            string tekstKlein = tekst.ToLower();

            bool isOk = true;
            foreach (string scheldwoord in scheldwoorden)
            {
                if (tekstKlein.Contains(scheldwoord))
                {
                    isOk = false;
                    break;
                }
            }

            if (isOk)
            {
                Console.WriteLine("Tekst is aanvaardbaar");
            }
            else
            {
                Console.WriteLine("Tekst is niet aanvaardbaar");
            }
        }
    }
}
