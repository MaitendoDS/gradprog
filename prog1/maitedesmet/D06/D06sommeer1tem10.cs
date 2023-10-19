using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    internal class D06sommeer1tem10
    {
        static void Main(string[] args)
        {
            int i = 0;
            int som = 0;

            for(i = 1; i <=10; i++)
            {
                int kwadraat = i * i;
                som = kwadraat + som;
            }
            Console.WriteLine(som);



        }
    }
}
