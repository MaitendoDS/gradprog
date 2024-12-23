using StripsBL.Interfaces;
using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Services
{
    public class StripService: IStripRepository
    {

        IStripRepository _stripRepository;

        public StripService(IStripRepository stripRepository)
        {

            _stripRepository = stripRepository;
        }


        public List<Strip> GetAll()
        {

            try
            {
                return _stripRepository.GetAll();
            }
            catch (Exception x)
            {

                throw new Exception("StripService-GetAll", x);
            }
        }


        public Strip GetStrip(int id)
        {
            try
            {
                return _stripRepository.GetStrip(id);
            }
            catch (Exception x)
            {
                throw new Exception("StripService-GetStrip", x);
            }
        }


        public Strip Update(Strip strip)
        {
            try
            {
                if (strip == null)
                {
                    throw new Exception("Strip is null");
                }

                return _stripRepository.Update(strip);


            }
            catch (Exception x)
            {

                throw new Exception("StripService-Update", x);
            }
        }
    }
}
