using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16socialmediafilter
    {
        static void Main()
        {
            // Maak een lijst van woorden die misschien gecensureerd moeten worden
            List<string> words = new List<string> { "oranje", "trump", "haar", "Trump", "bedrog", "verkiezingen", "winnaar" };

            // Maak een set van 'stoute woordjes' die we willen censureren
            HashSet<string> naughtyWords = new HashSet<string> { "Trump", "fraude", "verkiezingen" };

            // Toon eerste eens alle woorden
            Console.WriteLine(String.Join(",", words));

            // Censureer waar nodig
            List<string> gecensureerd = SocialMediaFilter(words, naughtyWords);

            // Toon de woorden opnieuw, dit keer geschikt voor gevoelige zieltjes
            Console.WriteLine(String.Join(",", gecensureerd));
        }

        static List<string> SocialMediaFilter(List<string> woorden, HashSet<string> stoutewoorden)
        {
            List<string> gecensureerd = new List<string>();

 

            for (int i = 0; i < woorden.Count; i++)
            {
                if (stoutewoorden.Contains(woorden[i]))
                {
                    int lengte = woorden[i].Length;
                    string sterretjes = "";

                    for (int j = 0; j < lengte; j++)
                    {
                        sterretjes = sterretjes + "*";
                    }
                    

                    gecensureerd.Add(sterretjes);
                } else
                {
                    gecensureerd.Add(woorden[i]);
                }
            }
            return gecensureerd;



        }
    }
}
