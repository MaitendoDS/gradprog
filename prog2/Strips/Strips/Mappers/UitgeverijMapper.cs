using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Mappers
{
    public class UitgeverijMapper
    {

        public static Uitgeverij MapToBL(UitgeverijEF uitgeverijEF)
        {
            try
            {
                return new Uitgeverij(
                uitgeverijEF.UitgeverijID,
                uitgeverijEF.Naam,
                uitgeverijEF.Adres
                    );

            }
            catch (Exception x)
            {
                throw new Exception("UitgeverijMapper-MapToBL", x);
            }

        }



        public static UitgeverijEF MapToDL(Uitgeverij uitgeverij)
        {
            try
            {
                return new UitgeverijEF(
                uitgeverij.UitgeverijID,
                uitgeverij.Naam,
                uitgeverij.Adres
                    );

            }
            catch (Exception x)
            {
                throw new Exception("UitgeverijMapper-MapToDL", x);
            }

        }
    }
}
