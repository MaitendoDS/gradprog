using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12soortenafrondingen
    {
        static void Main(string[] args)
        {
            decimal[] waarden = { 7.4m, 7.5m, 7.6m, -7.4m, -7.5m, -7.6m };

            foreach (decimal g in waarden)
            {
                Console.WriteLine(Math.Ceiling(g));
                Console.WriteLine(Math.Floor(g));
                Console.WriteLine(Math.Round(g));
                Console.WriteLine(Math.Round(g,MidpointRounding.AwayFromZero));
            }
        }
    }
}
