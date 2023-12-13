using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12doorsnede
    {
        //static void Main(string[] args)
        //{
        //    static void Main()
        //    {
        //        double[] temperaturenMeetpunt1 = { 10.1, 20.2, 15.5, 12.3, 28.7 };
        //        double[] temperaturenMeetpunt2 = { 10.0, 20.2, 15.6, 12.3, 28.8, 11.1 };

        //        double[] doorsnede = Doorsnede(temperaturenMeetpunt1, temperaturenMeetpunt2);
        //        ToonDoorsnede(doorsnede);                       // toont de tekst "20,2 | 12,3"

        //        double[] getallen1 = { 1.23, 2.34, 3.45 };
        //        double[] getallen2 = { 1.99, 2.34 };
        //        ToonDoorsnede(Doorsnede(getallen1, getallen2)); // toont de tekst "2,34"

        //        double[] getallen3 = { 1.99, 2.99, 3.99 };
        //        ToonDoorsnede(Doorsnede(getallen1, getallen3)); // toont de tekst "geen doorsnede"
        //    }
        //}
        //static double[] Doorsnede(double[] getallen1, double[] getallen2)
        //{
        //    int lengte = 0;

        //    if (getallen1.Length < getallen2.Length)
        //    {
        //        lengte = getallen2.Length;
        //    } else
        //    {
        //        lengte = getallen1.Length;
        //    }


        //    double[] doorsnede = new double[lengte];
        //    int i = 0;

        //    foreach (double getal in getallen1)
        //    {
        //        if (getal == getallen2[i])
        //        {
        //            doorsnede[i] = getal;
        //        }
        //        i++;

        //    }
        //    return doorsnede;

        //}

        //static void ToonDoorsnede(double[] doorsnede)
        //{
        //    if (doorsnede.Length >= 1)
        //    {
        //        Console.WriteLine($"Doorsnede: {string.Join(", ", doorsnede)}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("geen doorsnede");
        //    }
        //    }

        static void Main()
        {
            double[] temperaturenMeetpunt1 = { 10.1, 20.2, 15.5, 12.3, 28.7 };
            double[] temperaturenMeetpunt2 = { 9.0, 10.0, 20.2, 15.6, 12.3, 28.8, 11.1 };

            double[] doorsnede = Doorsnede(temperaturenMeetpunt1, temperaturenMeetpunt2);
            ToonDoorsnede(doorsnede);                       // toont de tekst "Doorsnede: 20,2 | 12,3"

            double[] getallen1 = { 1.23, 2.34, 3.45 };
            double[] getallen2 = { 1.99, 2.34 };
            ToonDoorsnede(Doorsnede(getallen1, getallen2)); // toont de tekst "Doorsnede: 2,34"

            double[] getallen3 = { 1.99, 2.99, 3.99 };
            ToonDoorsnede(Doorsnede(getallen1, getallen3)); // toont de tekst "geen doorsnede"
        }

        static void ToonDoorsnede(double[] doorsnede)
        {
            if (doorsnede.Length >= 1)
            {
                Console.WriteLine($"Doorsnede: {string.Join(", ", doorsnede)}");
            }
            else
            {
                Console.WriteLine("geen doorsnede");
            }
        }

        static double[] Doorsnede(double[] getallen1, double[] getallen2)
        {
            // Bepaal welke de korste en langste array is:
            double[] kortsteArray = getallen1;
            double[] langsteArray = getallen2;
            if (kortsteArray.Length > getallen2.Length)
            {
                kortsteArray = getallen2;
                langsteArray = getallen1;
            }

            // Tel het aantal waardes die in de doorsnede moeten terechtkomen:
            int aantalInDoorsnede = 0;
            for (int i = 0; i < kortsteArray.Length; i++)
            {
                for (int j = 0; j < langsteArray.Length; j++)
                {
                    if (kortsteArray[i] == langsteArray[j])
                    {
                        aantalInDoorsnede++;
                    }
                }
            }

            // Maak de array aan voor de doorsnede:
            double[] doorsnede = new double[aantalInDoorsnede];

            // Ga nogmaals door de twee arrays om de vereist waardes over te nemen in de doorsnede:
            int k = 0;
            for (int i = 0; i < kortsteArray.Length; i++)
            {
                for (int j = 0; j < langsteArray.Length; j++)
                {
                    if (kortsteArray[i] == langsteArray[j])
                    {
                        doorsnede[k] = kortsteArray[i];
                        k++;
                    }
                }
            }

            // Lever de doorsnede array op:
            return doorsnede;
        }
    }
}

