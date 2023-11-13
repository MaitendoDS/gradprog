using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09zoekhistoriek
    {
        static void Main(string[] args)
        {
            string[] zoekhistoriek = { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };

            do
            {
                Console.WriteLine(String.Join(":", zoekhistoriek));

                Console.Write("Nieuwe zoekterm: ");
                string input = Console.ReadLine();

                // We schuiven de zoektermen in de historiek naar voren, de eerste
                // gaat dus verloren (Charlie Sheen is sowieso al een lost cause)

                // Zonder loop zouden we dit schrijven :
                // zoekhistoriek[0] = zoekhistoriek[1];
                // zoekhistoriek[1] = zoekhistoriek[2];
                // zoekhistoriek[2] = zoekhistoriek[3];
                // zoekhistoriek[3] = zoekhistoriek[4];
                // zoekhistoriek[4]= input;

                // Maar we willen natuurlijk een oplossing die ook werkt als de lengte van de
                // zoekhistoriek niet noodzakelijk 5 is, dus gebruiken we een loop
                for (int i = 0; i < zoekhistoriek.Length - 1; i++)
                {
                    zoekhistoriek[i] = zoekhistoriek[i + 1];
                }
                // nieuwe zoekterm op het einde toevoegen
                zoekhistoriek[zoekhistoriek.Length - 1] = input;

                Console.WriteLine();
            } while (true);
        }
    }
}
