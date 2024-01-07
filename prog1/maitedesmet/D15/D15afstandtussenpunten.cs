using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15afstandtussenpunten
    {
        static void Main(string[] args)
        {
            Punt punt1 = new Punt(4,6);
            Punt punt2 = new Punt(7,2);

           


            Console.WriteLine($"De afstand tussen de twee punten is {punt1.GetAfstandTussen(punt1, punt2)}");



        }
    }
}
