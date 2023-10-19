using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05getalradengebruiker
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int willekeurigGetal = rnd.Next(1, 101);
            int gegoktGetal = 0;

            Console.WriteLine("Raad een willekeurig getal tussen 1 en 100");


            do
            { Console.Write("Doe een gokje: ");
               string ingevoerdeGok = Console.ReadLine();
               gegoktGetal = int.Parse(ingevoerdeGok);
                

                if (gegoktGetal > willekeurigGetal) { Console.WriteLine("Lager!"); }

                else if (gegoktGetal < willekeurigGetal) { Console.WriteLine("Hoger!"); }

                else { Console.WriteLine("Disco!!!!!!!"); }

            }
            while (gegoktGetal != willekeurigGetal);

        }
    }
}
