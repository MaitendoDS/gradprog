using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Mappers
{
    public class ReeksMapper
    {

        public static Reeks MapToBL(ReeksEF reeksEF)
        {
            try
            {
                return new Reeks(
                reeksEF.ReeksID,
                reeksEF.ReeksNaam,
                reeksEF.Strips.Select(StripMapper.MapToBLReeks).ToList() ?? new List<Strip>()
                    );

            }
            catch (Exception x)
            {
                throw new Exception("ReeksMapper-MapToBL", x);
            }

        }



        public static ReeksEF MapToDL(Reeks reeks)
        {

            try
            {
                return new ReeksEF(
                reeks.ReeksID,
                reeks.ReeksNaam,
                reeks.Strips.Select(StripMapper.MapToDL).ToList() ?? new List<StripEF>()

                    );

            }
            catch (Exception x)
            {

                throw new Exception("AuteurMapper-MapToDL", x);
            }
        }

        public static ReeksEF MapToDLZonderStrip(Reeks reeks)
        {

            try
            {
                return new ReeksEF(
                reeks.ReeksID,
                reeks.ReeksNaam
                    );

            }
            catch (Exception x)
            {

                throw new Exception("AuteurMapper-MapToDLZonderStrip", x);
            }
        }


    }
}
