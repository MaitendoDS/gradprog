using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05grootstegetal
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int max = 0;

            do
            {
                Console.Write("Geef een getal (-1 om te stoppen) :");
                string invoer = Console.ReadLine();
                getal = int.Parse(invoer);
              if (getal > max)
                {
                    max = getal;
                }
            
            } while (getal != -1);
            Console.WriteLine($"HEt grootste getal is {max}");

        }
    }
}
