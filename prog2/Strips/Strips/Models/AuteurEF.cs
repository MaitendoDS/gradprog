using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class AuteurEF
    {
        public AuteurEF(string naam)
        {
            Naam = naam;
        }

        public AuteurEF(int? auteurID, string naam, string? email)
        {
            AuteurID = auteurID;
            Naam = naam;
            Email = email;
        }

        [Key]
        public int? AuteurID { get; set; }
        public string Naam { get; set; }
        public string? Email { get; set; }

        
        public List<StripEF> Strips { get; set; }


    }
}
