using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
               Strip strip = new Strip();
                strip.StripID = stripEF.StripID;
                strip.Titel = stripEF.Titel;
                strip.Nummer = stripEF.Nummer;
                strip.ReeksNummer = stripEF.Reeks.ReeksID;
                strip.ReeksNaam = stripEF.Reeks.ReeksNaam;
                strip.Auteurs = stripEF.Auteurs.Select(AuteurMapper.MapToBL).ToList() ?? new List<Auteur>();
                strip.Uitgeverij = stripEF.Uitgeverij != null ? UitgeverijMapper.MapToBL(stripEF.Uitgeverij) : new Uitgeverij();
                
                return strip;
            }
            catch (Exception x)
            {
                throw new Exception("StripMapper-MapToBL", x);
            }

        }


        public static Strip MapToBLReeks(StripEF stripEF)
        {
            try
            {
                Strip strip = new Strip();
                strip.Titel = stripEF.Titel;
                strip.Nummer = stripEF.Nummer;
                strip.StripID = stripEF.StripID;
               
                return strip;
            }
            catch (Exception x)
            {
                throw new Exception("StripMapper-MapToBLReeks", x);
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
                strip.Reeks != null ? ReeksMapper.MapToDLZonderStrip(strip.Reeks) : new ReeksEF(),
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
