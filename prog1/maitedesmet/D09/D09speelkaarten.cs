using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09speelkaarten
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };

            string[] kaarten = new string[kleuren.Length * waarden.Length];

            // vul 'kaarten' array met alle combinaties
            int i = 0;
            foreach (string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    kaarten[i] = kleur + " " + waarde;
                    i++;
                }
            }

            // toon alle kaarten
            foreach (string kaart in kaarten)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}
