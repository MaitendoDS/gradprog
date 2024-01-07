using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16uniekegetallentonen
    {
        static void Main(string[] args)
        {
            bool gelukt;
            double getal = 0;

            List<double> getallen = new List<double>();

            for (int i = 0; i < 10;)
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
                    i++;
                }


            }
            getallen= getallen.Distinct().ToList();
            Console.Write($"{getallen.Count} unieke getallen: ");

            for (int i = 0;i < getallen.Count;i++)
            {
                
                Console.Write(getallen[i]+" ");
            }
          
        }
    }
}
