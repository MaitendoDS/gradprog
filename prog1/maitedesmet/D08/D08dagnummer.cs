using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08dagnummer
    {
        static void Main(string[] args)
        {
            string[] dagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag" };

            Console.Write("geef een nummer van een dag:");
            int input = int.Parse(Console.ReadLine());

            string dag = dagen[input-1];

            Console.WriteLine($"Dag nummer {input} is {dag}. ");
            
        }
    }
}
