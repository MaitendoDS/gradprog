using StripsBL.Interfaces;
using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Services
{
    public class ReeksService
    {

        IReeksRepository _reeksRepository;

        public ReeksService(IReeksRepository reeksRepository)
        {

            _reeksRepository = reeksRepository;
        }

        public List<Reeks> GetAll()
        {
            try
            {
                return _reeksRepository.GetAll();
            }
            catch (Exception x)
            {

                throw new Exception("ReeksService-GetAll", x);
            }
        }

        public Reeks GetReeks(int id)
        {
            try
            {
                return _reeksRepository.GetReeks(id);
            }
            catch (Exception x)
            {

                throw new Exception("ReeksService-GetReeks", x);
            }
        }


    }
}
