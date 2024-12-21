using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class UitgeverijEF
    {
        public UitgeverijEF()
        {
        }

        public UitgeverijEF(string naam)
        {
            Naam = naam;
        }

        public UitgeverijEF(int uitgeverijID, string naam, string? adres)
        {
            UitgeverijID = uitgeverijID;
            Naam = naam;
            Adres = adres;
        }

        [Key]
        public int UitgeverijID { get; set; }
        public string Naam { get; set; }
        public string? Adres { get; set; }


        public List<StripEF> Strips { get; set; }

    }
}
