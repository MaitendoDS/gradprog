using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapCyclingSession
    {
        public static CyclingSession MapToBL(CyclingSessionEF dl)
        {
            try
            {
                return new CyclingSession(
                    dl.CyclingSessionID,
                    dl.Date,
                    dl.Duration,
                    dl.AvgWatt,
                    dl.MaxWatt,
                    dl.AvgCadence,
                    dl.MaxCadence,
                    dl.TrainingType,
                    dl.Comment,
                    dl.MemberID
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapCyclingSession-MapToBL", x);
            }


        }

        public static CyclingSessionEF MapToDL(CyclingSession bl)
        {
            try
            {
                return new CyclingSessionEF(
                    bl.CyclingSessionID,
                    bl.Date,
                    bl.Duration,
                    bl.AvgWatt,
                    bl.MaxWatt,
                    bl.AvgCadence,
                    bl.MaxCadence,
                    bl.TrainingType,
                    bl.Comment,
                    bl.MemberID
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapCyclingSession-MapToDL", x);
            }


        }


    }
}
