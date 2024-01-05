using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class D14counter
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();

            Counter c2 = new Counter();
            c2.SetValue(100);

            Counter c3 = new Counter();
            c3.SetValue(1000);
            c3.SetStep(10);

            for (int i = 0; i < 10; i++)
            {
                c1.Advance();
                c2.Advance();
                c3.Advance();
            }

            Console.WriteLine(c1.GetValue());  // toont 10
            Console.WriteLine(c2.GetValue());  // toont 110
            Console.WriteLine(c3.GetValue());  // toont 1100
        }
    }
}
