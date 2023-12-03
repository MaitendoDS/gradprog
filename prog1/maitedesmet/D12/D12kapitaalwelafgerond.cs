using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12kapitaalwelafgerond
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is het startkapitaal?: ");
            decimal startkapitaal = decimal.Parse(Console.ReadLine());

            Console.Write("Aan welke intrestvoet? (in %): ");
            decimal intrestvoet = decimal.Parse(Console.ReadLine());

            decimal kapitaal = Math.Round(startkapitaal,2);

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"Jaar {i} : {kapitaal,0:f2}");
                kapitaal = Math.Round((kapitaal + (kapitaal / 100 * intrestvoet)),2);
            }
        }
    }
}
