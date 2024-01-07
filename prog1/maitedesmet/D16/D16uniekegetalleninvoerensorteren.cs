using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16uniekegetalleninvoerensorteren
    {
        static void Main(string[] args)
        {
            bool gelukt;
            double getal = 0;

            List<double> getallen = new List<double>();

            for (int i = 0; i < 10;)
            {

                Console.Write("Geef een uniek getal:  ");
                string getalAlsTekst = Console.ReadLine();
                gelukt = double.TryParse(getalAlsTekst, out getal);

                if (!gelukt)
                {
                    Console.WriteLine("ongeldige input");
                }
                else
                {
                    if (getallen.Contains(getal))
                    {
                        Console.WriteLine("het is een dubbel");
                    }
                    else
                    {
                        getallen.Add(getal);
                        i++;

                    }

                }


            }

            Console.Write($"{getallen.Count} unieke getallen: ");

            getallen.Sort();
            getallen.Reverse();

            for (int i = 0; i < getallen.Count; i++)
            {

                Console.Write(getallen[i] + " ");
            }

        }
    }
}


    
