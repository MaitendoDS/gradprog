using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05grootstegetalenaantal
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int max = 0;
            int aantal = 0;
            int teller = 0;

            do
            {
                Console.Write("Geef een getal (-1 om te stoppen) :");
                string invoer = Console.ReadLine();
                getal = int.Parse(invoer);


                if (getal != 1)
                {
                    teller++;
                    if (teller == 1 || getal > max)
                    {
                        max = getal;
                        aantal = 1;
                    }
                    else if (getal == max)
                    {
                        aantal++;
                    }
                }
                } while (getal != -1) ;
                Console.WriteLine($"Het grootste getal is {max} en het kwam {aantal} keer voor");
            
        }
    }
}
