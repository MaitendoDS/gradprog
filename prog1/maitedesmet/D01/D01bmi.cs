using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D01bmi
    {
        static void Main(string[] args)
        {
            int lengteInCm = 182;
            int gewichtInKg = 72;

            double lengteInM = lengteInCm / 100.0;
            double bmi = gewichtInKg / (lengteInM * lengteInM);

            Console.WriteLine(bmi);


        }
    }
}
