using FitnessBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;
using FitnessDL.Mappers;
using FitnessDL.Models;

namespace FitnessDL.Repositories
{
    public class ProgrammaRepository : IProgrammaRepository
    {

        FitnessContext _context;
        public ProgrammaRepository(FitnessContext context)
        {
            _context = context;

        }



        public Programma Add(Programma programma)
        {

            try
            {
                if (programma == null)
                {
                    throw new Exception("Programma is null"); 
                }

                var programmaEF = MapProgramma.MapToDL(programma);
                _context.Programma.Add(programmaEF);
                _context.SaveChanges();

                return MapProgramma.MapToBL(programmaEF);
              
            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaRepository-Add", x);
            }

        }

        public Programma Update(Programma programma)
        {

            try
            {
                ProgrammaEF programmaEF = _context.Programma.Find(programma.ProgramCode);

                if (programmaEF != null)
                {
                    _context.Entry(programmaEF).CurrentValues.SetValues(MapProgramma.MapToDL(programma));// entry is heel het rijtje in db
                    _context.SaveChanges();

                    return MapProgramma.MapToBL(programmaEF); //return een normaal programma ipv porgrammaEF

                }
                else
                {
                    throw new Exception("Programma niet gevonden");
                }




            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaRepository-Update", x);
            }

        }
        public bool Delete(int id)
        {

            try
            {
                ProgrammaEF programmaEF = new ProgrammaEF(); // zodat ef naar memberID kan kijken en dan de member met dezlfde id vverwijderen
                programmaEF.ProgramCode = id;
                _context.Remove(programmaEF);

                _context.SaveChanges();

                return true;

            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaRepository-Delete", x);
            }
        }


    }
}
