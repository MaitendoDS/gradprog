using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10toonrechthoek
    {
        static void Main()
        {
            bool juisteinvoer;
            int breedte = 0;
            do
            {
                Console.Write("Geef de breedte: ");
                string breedteAlsTekst = Console.ReadLine();
                juisteinvoer = int.TryParse(breedteAlsTekst, out breedte);
            } while (!juisteinvoer);
            
            int hoogte = 0;
            do
            {
                Console.Write("Geef de hoogte: ");
                string hoogteAlsTekst = Console.ReadLine();
                juisteinvoer = int.TryParse(hoogteAlsTekst, out hoogte);
            } while (!juisteinvoer);

            Console.WriteLine();
            ToonRechthoek(breedte,hoogte);

        }
        static void ToonRechthoek(int breedte, int hoogte)
        {
          for (int i = 0; i < hoogte; i++)
            {
                for (int j = 0; j < breedte; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
