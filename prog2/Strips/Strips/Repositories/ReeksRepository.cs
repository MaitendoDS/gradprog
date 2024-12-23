using Microsoft.EntityFrameworkCore;
using StripsBL.Interfaces;
using StripsBL.Models;
using StripsDL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Repositories
{
    public class ReeksRepository : IReeksRepository
    {
        StripsContext _context;
        public ReeksRepository(StripsContext context)
        {
            _context = context;
        }



        public Reeks GetReeks(int id)
        {
            try
            {
                var reeks = _context.Reeks.Include(r => r.Strips).FirstOrDefault(r => r.ReeksID == id);

                return reeks != null ? ReeksMapper.MapToBL(reeks) : throw new Exception("Reeks is null");

            }
            catch (Exception x)
            {

                throw new Exception("ReeksrRepository-GetReeks", x);
            }
        }

        public List<Reeks> GetAll()
        {
            try
            {
                return _context.Reeks
                    .Include(r => r.Strips)
                    .Select(r => ReeksMapper.MapToBL(r)).ToList();
            }
            catch (Exception x)
            {

                throw new Exception("ReeksRepository-GetAll", x); ;
            }
        }
    }
}
