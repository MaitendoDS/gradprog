using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04prijsappels
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal kilo aan te kopen appels?:");
            
           double aantalKilo = double.Parse(Console.ReadLine());

            double prijs = 3.0 ;

            double totaalPrijs = 1;

            if (aantalKilo >=20)
            {
                totaalPrijs = aantalKilo * 2;

            }
            else if (aantalKilo >= 10)
            {

                totaalPrijs = aantalKilo * 2.5;

            }
            else { totaalPrijs = aantalKilo * 3; }


            Console.WriteLine($"De prijs is {totaalPrijs} euro.");
       
            
            }
            
        }
    }

