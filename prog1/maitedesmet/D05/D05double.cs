using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05double
    {
        static void Main(string[] args)
        {
            Console.Write("voer een double getal in: ");
            double getal;
            bool invoerOk = (double.TryParse(Console.ReadLine(), out getal));


            while (invoerOk)
            {
                Console.WriteLine("Dank je voor het (double) getal.");
                Console.Write("Gelieve nog een (double) getal in te voeren: ");
                invoerOk = (double.TryParse(Console.ReadLine(), out getal));
            }
            Console.WriteLine("Einde (wegens geen double getal).");

        }
    }
}
