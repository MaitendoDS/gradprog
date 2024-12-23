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
    public class StripRepository : IStripRepository
    {
        StripsContext _context;
        public StripRepository(StripsContext context)
        {
            _context = context;
        }

        public List<Strip> GetAll()
        {
            try
            {
                return _context.Strip.Select(s => StripMapper.MapToBL(s)).ToList();


            }
            catch (Exception x)
            {

                throw new Exception("StripRepository-GetAll", x);
            }
        }

        public Strip GetStrip(int id)
        {
            try
            {
                var strip = _context.Strip
                    .Include(s => s.Auteurs)
                    .Include(s => s.Reeks)
                    .Include(s => s.Uitgeverij)
                    .FirstOrDefault(s => s.StripID == id);

                return strip != null ? StripMapper.MapToBL(strip) : throw new Exception("Strip is null");

            }
            catch (Exception x)
            {

                throw new Exception("StripRepository-GetStrip", x);
            }
        }

        public Strip DeleteOrAdd(int stripID, int auteurID)
        {
            try
            {
                StripEF stripEF = _context.Strip.Find(stripID);
                AuteurEF auteurEF = _context.Auteur.Find(auteurID);

                if (stripEF == null)
                {
                    throw new Exception("Strip is null");
                }

                if (auteurEF == null)
                {
                    throw new Exception("Auteur is null");
                }

                if (stripEF.Auteurs.Contains(auteurEF))
                {
                    stripEF.Auteurs.Remove(auteurEF);

                }
                else
                {
                    stripEF.Auteurs.Add(auteurEF);
                }
                return StripMapper.MapToBL(stripEF);

            }
            catch (Exception x)
            {
                throw new Exception("StripRepository-DeleteOrAdd", x);
            }
        }


        public Strip Add(Strip strip)
        {
            try
            {


                StripEF stripEF = _context.Strip.Where(s => s.Titel == strip.Titel && s.Reeks == ReeksMapper.MapToDL(strip.Reeks))
                    .FirstOrDefault();

                if (stripEF != null)
                {
                    throw new Exception("Strip bestaat al");
                }
                else
                {
                    _context.Strip.Add(StripMapper.MapToDL(strip));
                    _context.SaveChanges();
                    return strip;

                }

            }
            catch (Exception x)
            {

                throw new Exception("StripRepository-Add", x);
            }
        }

        public bool Delete(int id)
        {
            try
            {

                StripEF stripEF = _context.Strip.Find(id);

                if (stripEF != null)
                {
                    _context.Strip.Remove(stripEF);
                }
                else
                {
                    throw new Exception("Strip is null");
                }

                return true;


            }
            catch (Exception x)
            {

                throw new Exception("StripRepository-Delete", x);
            }
        }



        public Strip Update(Strip strip)
        {
            try
            {

                StripEF stripEF1 = _context.Strip.Where(s => s.Titel == strip.Titel && s.Reeks == ReeksMapper.MapToDL(strip.Reeks))
                    .FirstOrDefault();

                if (stripEF1 != null)
                {
                    throw new Exception("Strip bestaat al");
                }
                

                StripEF stripEF = _context.Strip.Find(strip.StripID);

                if (stripEF != null)
                {
                    _context.Entry(stripEF).CurrentValues.SetValues(StripMapper.MapToDL(strip));
                    _context.SaveChanges();

                    return StripMapper.MapToBL(stripEF);
                }
                else
                {
                    throw new Exception("Strip niet gevonden");
                }


            }
            catch (Exception x)
            {

                throw new Exception("StripRepository-Update", x);
            }
        }

    }
}
