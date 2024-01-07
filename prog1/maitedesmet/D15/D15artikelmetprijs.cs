using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15artikelmetprijs
    {
        static void Main(string[] args)
        {
            // Test de constructor met één parameter:
            Artikelmetprijs artikel1 = new Artikelmetprijs(100m);
            Console.WriteLine(artikel1.Prijs == 100m);    // zou true moeten opleveren
            Console.WriteLine(artikel1.BTW == 21m);         // zou true moeten opleveren
            Console.WriteLine(artikel1.PrijsIncl() == 121m);  // zou true moeten opleveren

            // Test of de __setters__ nog correct functioneren:
            artikel1.Prijs = 1000m;
            artikel1.BTW = 6m;
            Console.WriteLine(artikel1.Prijs == 1000m);   // zou true moeten opleveren
            Console.WriteLine(artikel1.BTW == 6m);          // zou true moeten opleveren
            Console.WriteLine(artikel1.PrijsIncl() == 1060m); // zou true moeten opleveren

            // Test de constructor met twee parameters:
            Artikelmetprijs artikel2 = new Artikelmetprijs(200m, 6m);
            Console.WriteLine(artikel2.Prijs == 200m);    // zou true moeten opleveren
            Console.WriteLine(artikel2.BTW == 6m);          // zou true moeten opleveren
            Console.WriteLine(artikel2.PrijsIncl() == 212m);  // zou true moeten opleveren

            // Test uit of de prijs exclusief BTW wel verplicht is,
            // volgende regel code zou dan ook een compile-fout moeten opleveren:
            //Artikelmetprijs artikel3 = new Artikelmetprijs();
            // Zet bovenstaande regel in commentaar indien hij daadwerkelijk een
            // compile-fout oplevert, dan heb je bereikt wat de bedoeling was
        }
    }
}
