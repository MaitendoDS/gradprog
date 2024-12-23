using Microsoft.EntityFrameworkCore;
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
    public class UitgeverijRepository : IUitgeverijRepository
    {
        StripsContext _context;
        public UitgeverijRepository(StripsContext context)
        {
            _context = context;
        }

        public Uitgeverij GetUitgeverij(int id)
        {
            try
            {
                var uitgeverij = _context.Uitgeverij.FirstOrDefault(u=>u.UitgeverijID == id);

                return uitgeverij != null ? UitgeverijMapper.MapToBL(uitgeverij) : throw new Exception("Uitgeverij is null");

            }
            catch (Exception x)
            {

                throw new Exception("UitgeverijRepository-GetUitgeverij", x);
            }
        }

        public List<Uitgeverij> GetAll()
        {
            try
            {

                return _context.Uitgeverij.Select(u=> UitgeverijMapper.MapToBL(u)).ToList();

            }
            catch (Exception x)
            {

                throw new Exception("UitgeverijRepository-GetAll", x);
            }
        }

        public Uitgeverij Update(Uitgeverij uitgeverij)
        {
            try
            {

                UitgeverijEF uitgeverijEF = _context.Uitgeverij.Find(uitgeverij.UitgeverijID);

                if (uitgeverij != null)
                {
                    _context.Entry(uitgeverijEF).CurrentValues.SetValues(UitgeverijMapper.MapToDL(uitgeverij)); //entry is het hele lijntje in db
                    _context.SaveChanges();

                    return UitgeverijMapper.MapToBL(uitgeverijEF); // return nromale uitgeverij ipv uitgeverijEF
                }
                else
                {
                    throw new Exception("Uitgeverij niet gevonden");
                }
            }
            catch (Exception x)
            {

                throw new Exception("UitgeverijRepository-Update", x);
            }
        }


    }
}
