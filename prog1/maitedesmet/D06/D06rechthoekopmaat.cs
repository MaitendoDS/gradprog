using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D06rechthoekopmaat
    {
        static void Main(string[] args)
        {
            bool gelukt;
            int breedte = 0;

            do { 
            Console.Write("Breedte?: ");
            string breedteAlsTekst = Console.ReadLine();
            gelukt = int.TryParse(breedteAlsTekst, out breedte);

        } while (!gelukt || breedte < 1);

            int hoogte = 0;

            do
            {
                Console.Write("Hoogte?: ");
                string hoogteAlsTekst = Console.ReadLine();
                gelukt = int.TryParse(hoogteAlsTekst, out hoogte);
            } while (!gelukt || hoogte < 1);

            //bouw een sterretjeslijn van de correcte breedte

            string lijn = "";
            for (int i = 0; i<breedte; i++)
            {
                lijn = lijn + "*";
            }

            //toon de lijn hoogte x keer op de console
            
            for (int i = 0;i < hoogte; i++) { Console.WriteLine(lijn); }
        }
    }
}
