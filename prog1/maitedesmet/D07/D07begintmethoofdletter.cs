using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07begintmethoofdletter
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een stukje tekst:");
            string input = Console.ReadLine();

            char c = input[0];
            bool hoofdletter = char.IsUpper(c);

            if (hoofdletter) { Console.WriteLine("De tekst start met een hoofdletter."); }
            else { Console.WriteLine("De tekt start met een kleine letter."); }
        }
    }
}
