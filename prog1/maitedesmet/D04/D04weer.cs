using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04weer
    {
        static void Main(string[] args)
        {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            bool hetRegent = (regen == "ja");

            if (deZonSchijnt && hetRegent)
            {
                Console.WriteLine("Regenboog.");

            }
            else if (hetRegent && !deZonSchijnt)
            {
                Console.WriteLine("Slecht weer.");
            }
            else if (!hetRegent && deZonSchijnt)
            {
                Console.WriteLine("Mooi weer.");

            }
            else { Console.WriteLine("Saaie dag."); }
        }
    }
}
