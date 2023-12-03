using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12tonenmetformaatstring
    {
        static void Main(string[] args)
        {
            DateTime nu = DateTime.Now;

            string datum =nu.ToString("dd/MM/yyyy");
            string tijd = nu.ToString("HHumm");

            Console.WriteLine($"De datum vandaag is {datum} en de tijd is {tijd}.");
        }
    }
}
