using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16vijfkleinstegetallen
    {
        static void Main(string[] args)
        {

            bool gelukt;
            double getal = 0;

            List<double> getallen = new List<double>();

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Geef getal:  ");
                string getalAlsTekst = Console.ReadLine();
                gelukt = double.TryParse(getalAlsTekst, out getal);

                if (!gelukt)
                {
                    Console.WriteLine("ongeldige input");
                }
                else
                {
                    getallen.Add(getal);
                }


            }
            Console.Write("de 5 kleinste zijn: ");

            getallen.Sort();
            for (int i = 0;i < 5;i++)
            {
                Console.Write(getallen[i]+", ");
            }

        }
    }
}
