using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11getalinput
    {
        static void Main()
        {
            int getal = GetGetal(1, 100);
            Console.WriteLine($"U koos voor {getal}");
        }
        static int GetGetal(int min, int max)
        {
            bool invoerOk = false;
            int invoer;
            do
            {
                Console.Write($"Geef een getal tussen {min} en {max}: ");
                invoerOk = int.TryParse(Console.ReadLine(), out invoer);

            } while (invoerOk != true);
            return invoer;
        }
        
    }
}
