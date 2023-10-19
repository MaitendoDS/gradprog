using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05som
    {
        static void Main(string[] args)

        {

            int som = 0;
            int getal = 0;

            do
            {
                Console.Write("Geef een getal (-1 om te stoppen) :");
                string invoer = Console.ReadLine();
                getal = int.Parse(invoer);
                if (getal != -1) {
                     som += getal;
            }
            } while (getal != -1);
            Console.WriteLine($"De som is {som}");

            



        }
    }
}
