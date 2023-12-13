using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12bertbevermettimespan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Druk 2x na elkaar op dezelfde toets, zo snel mogelijk..");

            char c1 = Console.ReadKey(true).KeyChar;
            DateTime dt1 = DateTime.Now;

            char c2 = Console.ReadKey(true).KeyChar;
            DateTime dt2 = DateTime.Now;

            if (c1 == c2)
            {
                TimeSpan ts = dt2 - dt1;
                Console.WriteLine($"De tijd ertussen bedroeg {ts.TotalMilliseconds}ms");
            }
            else
            {
                Console.WriteLine("Dat waren 2 verschillende toetsen!");
            }
        }
    }
}
