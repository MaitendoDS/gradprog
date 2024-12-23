using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class StripEF
    {
        public StripEF()
        {
        }

        public StripEF(int stripID, string titel, int? nummer, ReeksEF reeksEF, List<AuteurEF>? auteurs, UitgeverijEF? uitgeverij)
        {
            StripID = stripID;
            Titel = titel;
            Nummer = nummer;
            Reeks = reeksEF;
            Auteurs = auteurs;
            Uitgeverij = uitgeverij;
        }

        [Key]
        public int StripID { get; set; }
        public string Titel { get; set; }
        public int? Nummer { get; set; }
        public int? ReeksNummer { get; set; }
        public string? ReeksNaam { get; set; }

        public ReeksEF Reeks { get; set; }
        public List<AuteurEF>? Auteurs { get; set; }
        public UitgeverijEF? Uitgeverij { get; set; }




    }
}
