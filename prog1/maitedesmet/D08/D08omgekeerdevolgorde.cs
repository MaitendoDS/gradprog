using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08omgekeerdevolgorde
    {
        static void Main(string[] args)
        {

            string[] namen = new string[4];
            
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"geef naam {i+1}");
                string naam = Console.ReadLine();
                namen[i] = naam;
            }
            for (int i = namen.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}
