using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal:");
            string ingevoerdeGetal = Console.ReadLine();

            int getal = int.Parse(ingevoerdeGetal);
           
            if (getal % 2 == 0) { Console.WriteLine("Het getal is even."); }
            else { Console.WriteLine("Het getal is oneven."); }
        }
    }
}
