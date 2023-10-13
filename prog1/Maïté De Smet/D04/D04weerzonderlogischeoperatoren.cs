using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04weerzonderlogischeoperatoren
    {
        static void Main(string[] args)
        {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            bool hetRegent = (regen == "ja");

            if (deZonSchijnt)
            {
                if (hetRegent)
                { Console.WriteLine("Regenboog."); }

                else { Console.WriteLine("Mooi weer."); }
            }
            else { if (hetRegent) { Console.WriteLine("Slecht weer"); }
            else Console.WriteLine("Saaie dag.");
            }

        }
    }
}
