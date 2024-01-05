using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class D14selecteerwinnaar
    {
        static void Main(string[] args)
        {
            Persoon rik = new Persoon();
            Persoon dean = new Persoon();
            Persoon domien = new Persoon();
            Persoon josima = new Persoon();
            Persoon boris = new Persoon();

            rik.SetNaam("rik");
            dean.SetNaam("dean");
            domien.SetNaam("domien");
            josima.SetNaam("josima");
            boris.SetNaam("boris");


            Persoon[] personen = {rik, dean, domien, josima, boris };

            SelecteerWinnaar(personen);

        }
        static void SelecteerWinnaar(Persoon[] personen)
        {
            
            Random r = new Random();


            Console.WriteLine(personen[r.Next(0,4)].GetNaam());
        }

    }
}
