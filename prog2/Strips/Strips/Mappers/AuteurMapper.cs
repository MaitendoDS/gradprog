using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Mappers
{
    public static class AuteurMapper
    {
        public static Auteur MapToBL(AuteurEF auteurEF)
        {
            try
            {
                return new Auteur(
                auteurEF.AuteurID,
                auteurEF.Naam,
                auteurEF.Email
                    );

            }
            catch (Exception x)
            {
                throw new Exception("AuteurMapper-MapToBL", x);
            }

        }



        public static AuteurEF MapToDL(Auteur auteur)
        {

            try
            {
                return new AuteurEF(
                    auteur.AuteurID,
                    auteur.Naam,
                    auteur.Email

                    );
                              
            }
            catch (Exception x)
            {

                throw new Exception("AuteurMapper-MapToDL", x);
            }
        }

    }
}
