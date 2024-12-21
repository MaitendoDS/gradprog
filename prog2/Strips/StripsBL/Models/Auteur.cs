using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class Auteur
    {
        public Auteur(int? auteurID, string naam, string email)
        {
            AuteurID = auteurID;
            Naam = naam;
            Email = email;
        }

        public int? AuteurID { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }


    }
}
