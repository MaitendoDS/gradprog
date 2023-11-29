using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10faculteit
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int invoer = int.Parse(Console.ReadLine());
                       
            Console.WriteLine(GetFaculteit(invoer));

            

        }
        static int GetFaculteit(int getal)
        {


            int product = 1;
            for (int i = 2; i <= getal; i++)
            {
                product = product * i;

            }
            return product;

            
        }
    }
}
