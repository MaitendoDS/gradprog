using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class Strip

    {
        public Strip()
        {
        }

        public Strip(int stripID, string titel, int nummer, Reeks reeks, List<Auteur> auteurs, Uitgeverij uitgeverij)
        {
            StripID = stripID;
            Titel = titel;
            Nummer = nummer;
            Reeks = reeks;
            Auteurs = auteurs;
            Uitgeverij = uitgeverij;
        }

        public int StripID { get; set; }
        public string Titel { get; set; }
        public int Nummer { get; set; }

        public Reeks Reeks { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public Uitgeverij Uitgeverij { get; set; }
    }
}
