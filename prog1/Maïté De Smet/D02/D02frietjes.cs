using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02frietjes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een naam:");
            string naam1 = Console.ReadLine();

            Console.WriteLine("Geef nog een naam:");
            string naam2 = Console.ReadLine();

            Console.WriteLine("Geef een gerecht:");
            string gerecht = Console.ReadLine();

            Console.WriteLine(naam1 + " en " + naam2 + " eten graag " + gerecht + ".");
        }
    }
}
