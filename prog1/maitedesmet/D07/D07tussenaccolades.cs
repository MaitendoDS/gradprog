using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07tussenaccolades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een teskts: ");
            string tekst = Console.ReadLine();

            int indexLinks = tekst.IndexOf("{");
                int indexRechts = tekst.IndexOf("}");

            if (indexLinks != -1 ) && indexRechts !=-1 && indexLinks<indexRechts) {
            
            
            }
        }
    }
}
