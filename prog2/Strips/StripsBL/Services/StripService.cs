using StripsBL.Interfaces;
using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Services
{
    public class StripService : IStripRepository
    {

        IStripRepository _stripRepository;

        public StripService(IStripRepository stripRepository)
        {

            _stripRepository = stripRepository;
        }

        public bool Delete(int id)
        {
            try
            {

                return _stripRepository.Delete(id);
            }
            catch (Exception x)
            {

                throw new Exception("StripService-Delete", x);
            }
        }

        public Strip Add(Strip strip)
        {
            try
            {
                return _stripRepository.Add(strip);
            }
            catch (Exception x)
            {

                throw new Exception("StripService-Add", x);
            }
        }

        public Strip DeleteOrAdd(int stripID, int auteurID)
        {
            try
            {
                return _stripRepository.DeleteOrAdd(stripID, auteurID);
            }
            catch (Exception x)
            {

                throw new Exception("StripService-DeleteOrAdd", x);
            }
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
