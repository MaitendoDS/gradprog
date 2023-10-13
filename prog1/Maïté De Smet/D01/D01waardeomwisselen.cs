using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D01waardeomwisselen
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;

            int tijdelijk = a;
            a = b;
            b = tijdelijk;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
