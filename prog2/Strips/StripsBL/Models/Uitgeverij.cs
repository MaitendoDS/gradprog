using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class Uitgeverij
    {
        public Uitgeverij()
        {
        }

        public Uitgeverij(int uitgeverijID, string naam, string adres)
        {
            UitgeverijID = uitgeverijID;
            Naam = naam;
            Adres = adres;
        }

        public int UitgeverijID { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }



    }
}
