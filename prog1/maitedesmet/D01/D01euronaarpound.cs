using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D01euronaarpound
    {
        static void Main(string[] args)
        {
            double euroBedrag = 105.4;
            double poundBedrag = euroBedrag * 0.88;

            Console.Write(euroBedrag);
            Console.Write("EUR = ");
            Console.Write(poundBedrag);
            Console.Write("GPB");

        }
    }
}
