using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12kortingplusbtw
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een prijs excl BTW: ");
            decimal prijsExclBTW = decimal.Parse(Console.ReadLine());

            Console.Write("Geef de korting in %: ");
            decimal inputKorting = decimal.Parse(Console.ReadLine());

            Console.Write("Geef het BTW-tarief in %: ");
            decimal inputBTW = decimal.Parse(Console.ReadLine());

            decimal korting = prijsExclBTW /100 * inputKorting;
            korting = Math.Round(korting,2,MidpointRounding.AwayFromZero);

            decimal prijsMetKorting = prijsExclBTW - korting;

            decimal BTW = prijsMetKorting /100 * inputBTW;
            BTW = Math.Round(BTW, 2);
            decimal prijsInclBTW = prijsMetKorting + BTW;


            Console.WriteLine($"Excl BTW: {prijsExclBTW,7:f2}");
            Console.WriteLine($" korting: {korting,7:f2}");
            Console.WriteLine($"     btw: {BTW,7:f2}");
            Console.WriteLine($"incl btw: {prijsInclBTW,7:f2}");

        }
    }
}
