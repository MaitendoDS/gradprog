using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12kapitaalnietafgerond
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is het startkapitaal?: ");
            decimal startkapitaal = decimal.Parse(Console.ReadLine());

            Console.Write("Aan welke intrestvoet? (in %): ");
            decimal intrestvoet = decimal.Parse(Console.ReadLine());

            decimal kapitaal = startkapitaal;

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"Jaar {i} : {kapitaal, 0:f2}");
                kapitaal = kapitaal + (kapitaal / 100 * intrestvoet);
            }
        }
    }
}
