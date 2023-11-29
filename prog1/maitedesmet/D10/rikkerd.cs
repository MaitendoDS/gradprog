using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class rikkerd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal a neef: ");
            int input= int.Parse(Console.ReadLine());

            Console.WriteLine($"{input}! is {GetFaculteit(input)} ");
        }

        static int GetFaculteit(int invoer)
        {
            int resultaat = 1 ;

            for (int i = 2 ; i <= invoer; i++)
            {
                resultaat = resultaat * i ; 
            }
            return resultaat;
        }

    }
}


//static void Main(string[] args)
//{
//    Console.WriteLine("geef een eerste getal");
//    int invoer1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("geef een tweede getal");
//    int invoer2 = int.Parse(Console.ReadLine());

//    Console.WriteLine("geef een derde getal");
//    int invoer3 = int.Parse(Console.ReadLine());

//    Console.WriteLine("geef een vierde getal");
//    int invoer4 = int.Parse(Console.ReadLine());


//    IsOverlappend(invoer1, invoer2, invoer3, invoer4);

//Console.WriteLine($"");
//    string gender;

//}

//static bool IsOverlappend(int minInterval1, int maxInterval1, int minInterval2, int maxInterval2)
//{




//    if (minInterval1 > maxInterval1)
//    {
//        return false;
//    }
//    if (minInterval2 > maxInterval2)
//    {
//        return false;
//    }

//    if (minInterval1 < maxInterval1)
//    {

//    }
//    //minInterval1 <= maxInterval1;

//    //minInterval2 <= maxInterval2;
//}