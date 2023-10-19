using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    internal class D06rechthoekigedriehoeklinks
    {
        static void Main(string[] args)
        {
            bool gelukt;
            int hoogte = 0;



            do
            {
                Console.Write("Geef de hoogte:  ");
                string hoogteAlsTekst = Console.ReadLine();
                gelukt = int.TryParse(hoogteAlsTekst, out hoogte);
            } while (!gelukt || hoogte < 1);


            for (int aantal = 1; aantal <= hoogte; aantal++)
            {
                for (int i = 0; i< aantal; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
