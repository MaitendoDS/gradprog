using StripsBL.Interfaces;
using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Services
{
    public class UitgeverijService
    {
        IUitgeverijRepository _uitgeverijRepository;

        public UitgeverijService(IUitgeverijRepository uitgeverijRepository)
        {

            _uitgeverijRepository = uitgeverijRepository;
        }


        public List<Uitgeverij> GetAll()
        {

            try
            {
                return _uitgeverijRepository.GetAll();
            }
            catch (Exception x)
            {

                throw new Exception("UitgeverijService-GetAll", x);
            }
        }


        public Uitgeverij GetUitgeverij(int id)
        {
            try
            {
                return _uitgeverijRepository.GetUitgeverij(id);
            }
            catch (Exception x)
            {
                throw new Exception("UitgeverijService-GetUitgeverij", x);
            }
        }


        public Uitgeverij Update(Uitgeverij uitgeverij)
        {
            try
            {
                if (uitgeverij == null)
                {
                    throw new Exception("Uitgeverij is null");
                }

                return _uitgeverijRepository.Update(uitgeverij);


            }
            catch (Exception x)
            {

                throw new Exception("UitgeverijService-Update", x);
            }
        }

    }
}
