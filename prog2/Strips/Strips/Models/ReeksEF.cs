using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class ReeksEF
    {
        public ReeksEF()
        {
        }

        public ReeksEF(string reeksNaam)
        {
            ReeksNaam = reeksNaam;
        }

        public ReeksEF(int reeksID, string reeksNaam)
        {
            ReeksID = reeksID;
            ReeksNaam = reeksNaam;
        }

        public ReeksEF(int reeksID, string reeksNaam, List<StripEF> strips)
        {
            ReeksID = reeksID;
            ReeksNaam = reeksNaam;
            Strips = strips;
        }

        [Key]
        public int ReeksID { get; set; }
        public string ReeksNaam { get; set; }

        public List<StripEF> Strips { get; set; }

    }
}
