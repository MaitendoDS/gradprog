using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class Auteur
    {
        public Auteur(int auteurID, string email, string naam)
        {
            AuteurID = auteurID;
            Email = email;
            Naam = naam;
        }

        public int AuteurID { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }


    }
}
