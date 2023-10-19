using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05somofverschil
    {
        static void Main(string[] args)
        {
            int uitkomst = int.Parse(Console.ReadLine());
            string teken= Console.ReadLine();

            while (teken != "=") {
                int getal = int.Parse(Console.ReadLine());

                if (teken == "+")
                {
                    uitkomst = uitkomst + getal;
                }
                else if (teken == "-")
                {
                    uitkomst = uitkomst - getal;
                }
                teken = Console.ReadLine();

            }
            Console.WriteLine(uitkomst);

        }
    }
}
