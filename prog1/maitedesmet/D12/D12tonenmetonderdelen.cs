using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12tonenmetonderdelen
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            Console.WriteLine($"De datum van vandaag is {vandaag.Day,2:d2}/{vandaag.Month,2:d2}/{vandaag.Year,2:d2} en het is nu {vandaag.Hour,2:d2}u{vandaag.Minute,2:d2}.");
        }
    }
}
