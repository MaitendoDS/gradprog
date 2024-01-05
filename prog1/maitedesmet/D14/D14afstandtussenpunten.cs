using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    class D14afstandtussenpunten
    {
        static void Main(string[] args)
        {
            Punt punt1 = new Punt();
            Punt punt2 = new Punt();

            punt1.x = 4;
            punt1.y = 6;

            punt2.x = 7;
            punt2.y = 2;


            Console.WriteLine(punt1.GetAfstandTussen(punt1,punt2));



        }
    }
}
