using Strips;
using StripsBL.Interfaces;
using StripsBL.Models;
using StripsDL.Mappers;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Repositories
{
    public class AuteurRepository : IAuteurRepository
    {
        StripsContext _context;
        public AuteurRepository(StripsContext context)
        {
            _context = context;
        }


        public Auteur Update(Auteur auteur)
        {
            try
            {
                AuteurEF auteurEF = _context.Auteur.Find(auteur.AuteurID);

                if (auteurEF != null)
                {
                    _context.Entry(auteurEF).CurrentValues.SetValues(AuteurMapper.MapToDL(auteur));
                    _context.SaveChanges();


                    return AuteurMapper.MapToBL(auteurEF);
                }
                else
                {
                    throw new Exception("Auteur niet gevonden");
                }

            }
            catch (Exception x)
            {

                throw new Exception("AuteurRepository-Update", x);
            }
        }

    }
}
