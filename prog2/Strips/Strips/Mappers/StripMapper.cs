using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Mappers
{
    public class StripMapper
    {

        public static Strip MapToBL(StripEF stripEF)
        {
            try
            {
                return new Strip(
                stripEF.StripID,
                stripEF.Titel,
                stripEF.Nummer,
                stripEF.Reeks != null ? ReeksMapper.MapToBL(stripEF.Reeks) : new Reeks(),
                stripEF.Auteurs.Select(AuteurMapper.MapToBL).ToList() ?? new List<Auteur>(),
                stripEF.Uitgeverij != null ? UitgeverijMapper.MapToBL(stripEF.Uitgeverij) : new Uitgeverij()


                    );

            }
            catch (Exception x)
            {
                throw new Exception("StripMapper-MapToBL", x);
            }

        }

        public static StripEF MapToDL(Strip strip)
        {
            try
            {
                return new StripEF(
                strip.StripID,
                strip.Titel,
                strip.Nummer,
                strip.Reeks != null ? ReeksMapper.MapToDL(strip.Reeks) : new ReeksEF(),
                strip.Auteurs.Select(AuteurMapper.MapToDL).ToList() ?? new List<AuteurEF>(),
                strip.Uitgeverij != null ? UitgeverijMapper.MapToDL(strip.Uitgeverij) : new UitgeverijEF()


                    );

            }
            catch (Exception x)
            {
                throw new Exception("StripMapper-MapToDL", x);
            }

        }

    }
}
