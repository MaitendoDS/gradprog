using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class Reeks
    {
        public Reeks()
        {
        }

        public Reeks(int reeksID, string reeksNaam, List<Strip> strips)
        {
            ReeksID = reeksID;
            ReeksNaam = reeksNaam;
            Strips = strips;
        }

        public int ReeksID { get; set; }
        public string ReeksNaam { get; set; }

        public List<Strip> Strips { get; set; }

    }
}
