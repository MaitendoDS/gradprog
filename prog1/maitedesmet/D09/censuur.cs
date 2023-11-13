using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class censuur
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "kamelenneuker", "kaashoer", "kankernicht", "foefkop", "erwtenteller", "aambeienlikker" };

            Console.Write("Geef een tekst : ");
            string tekst = Console.ReadLine();
            string tekstKlein = tekst.ToLower();

            foreach (string scheldwoord in scheldwoorden)
            {
                int index = tekstKlein.IndexOf(scheldwoord);
                while (index != -1)
                {
                    int lengte = scheldwoord.Length;
                    tekst = tekst.Remove(index, lengte);
                    string sterretjes = new string('*', lengte);

                    tekst = tekst.Insert(index, sterretjes);

                    index = tekstKlein.IndexOf(scheldwoord, index + lengte);
                }
            }
            Console.WriteLine(tekst);
        }
    }
}
