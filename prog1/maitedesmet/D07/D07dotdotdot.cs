using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07dotdotdot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een tekst: ");
            string input = Console.ReadLine();

            foreach (char c in input) { Console.Write($"{c}.");
            }
        }
    }
}
