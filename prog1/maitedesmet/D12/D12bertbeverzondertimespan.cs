using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12bertbeverzondertimespan
    {
        static void Main(string[] args)
        {
            const int ticksPerMilliseconde = 10000;
            Console.WriteLine("Druk zo snel mogelijk 2x na elkaar op dezelfde toets");

            char c1 = Console.ReadKey(true).KeyChar;
            long ticks1 = DateTime.Now.Ticks;

            char c2 = Console.ReadKey(true).KeyChar;
            long ticks2 = DateTime.Now.Ticks;

            if (c1 == c2)
            {
                long ticks = ticks2 - ticks1;
                long milliseconden = ticks / ticksPerMilliseconde;

                Console.WriteLine($"De tijd ertussen was {milliseconden}ms");
            }
            else
            {
                Console.WriteLine("Dat zijn twee versch toesten...");
            }
        }
    }
}