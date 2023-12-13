using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12gethuurbedrag
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHuurBedrag(new DateTime(2022, 11, 20, 16, 45, 00), new DateTime(2022, 11, 20, 17, 15, 00), 10));
            Console.WriteLine(GetHuurBedrag(new DateTime(2022, 11, 20, 16, 45, 00), new DateTime(2022, 11, 23, 16, 15, 00), 10));
            Console.WriteLine(GetHuurBedrag(new DateTime(2022, 11, 20, 16, 45, 00), new DateTime(2022, 11, 23, 17, 15, 00), 10));
        }
        static double GetHuurBedrag(DateTime afgehaald, DateTime teruggebracht, double dagPrijs)
        {
            TimeSpan ts = teruggebracht - afgehaald;

            double prijs = (ts.Days+1) * dagPrijs;
            return prijs;

        }
    }
}
