using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09durstenfeld
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

            // Durstenfeld shuffle
            Random rnd = new Random();
            for (int huidigePositie = kaarten.Length - 1; huidigePositie >= 1; huidigePositie--)
            {
                int randomPositie = rnd.Next(huidigePositie + 1);
                // verwissel de kaarten op 'huidigePositie' en 'randomPositie'
                string temp = kaarten[huidigePositie];
                kaarten[huidigePositie] = kaarten[randomPositie];
                kaarten[randomPositie] = temp;
                // Als je de verwisselingen wil checken, haal onderstaande uit commentaar
                // Console.WriteLine($"wissel posities {huidigePositie} en {randomPositie}");
            }

            // toon alle kaarten
            foreach (string kaart in kaarten)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}
