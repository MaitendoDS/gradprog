using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace D10
{
    internal class D10vraaggebruikerompositiefgetal
    {
        static void Main()
        {
            int breedte = VraagGebruikerOmPostiefGetal("Geef de breedte");
            int hoogte = VraagGebruikerOmPostiefGetal("Geef de hoogte");

            Console.WriteLine();
            ToonRechthoek(breedte, hoogte);

        }
        static int VraagGebruikerOmPostiefGetal(string vraag)
        {
            bool juisteInvoer;
            int lengte;
            do
            {
                Console.WriteLine(vraag);
                string invoer = Console.ReadLine();
                juisteInvoer = int.TryParse(invoer, out lengte);
            } while (!juisteInvoer);
            return lengte;
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
