using FitnessBL.Interfaces;
using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Services
{
    public class ProgrammaService
    {
        IProgrammaRepository _programmaRepository;

        public ProgrammaService(IProgrammaRepository programmaRepository)
        {
            _programmaRepository = programmaRepository;

        }

        public Programma Add(Programma programma)
        {


            try
            {

                return _programmaRepository.Add(programma);
            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaService-Add",x);
            }
        }

        public Programma Update(Programma programma)
        {


            try
            {

                return _programmaRepository.Update(programma);
            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaService-Update", x);
            }
        }
        public bool Delete(string id)
        {
            try
            {
                _programmaRepository.Delete(id);

                return true;
            }
            catch (Exception x)
            {

                throw new Exception("ProgrammaService-Delete", x);
            }
        }




    }
}
