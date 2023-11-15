using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08volgordeomwisselen
    {
        static void Main(string[] args)
        {
            Console.Write("hoeveel namen wil je ingeven?: ");
            int aantalNamen = int.Parse(Console.ReadLine());

            string[] namen = new string[aantalNamen];

            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write($"geef naam {i + 1}: ");
                string naam = Console.ReadLine();
                namen[namen.Length - 1 - i] = naam;

              
            }
            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }
        }
    }
}

//namespace D08VolgordeOmwisselen
//{
//    internal class D08VolgordeOmwisselen
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Hoeveel namen wil je ingeven: ");
//            int aantalNamen = int.Parse(Console.ReadLine());
//            string[] namen = new string[aantalNamen];
//            for (int i = 0; i < namen.Length; i++)
//            {
//                Console.Write($"Geef naam {i}: ");
//                namen[i] = Console.ReadLine();
//            }
//            Console.WriteLine("");
//            Console.WriteLine("--- Omgekeerde volgorde ---");
//            for (int i = 0; i < namen.Length; i++)
//            {
//                int index = (namen.Length - 1) - i;
//                Console.WriteLine("naam " + index + ": " + namen[index]);
//            }
//        }
//    }
//}