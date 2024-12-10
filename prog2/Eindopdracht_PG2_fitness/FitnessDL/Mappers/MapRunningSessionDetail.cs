using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapRunningSessionDetail
    {
        public static RunningSession_Detail MapToBL(RunningSession_DetailEF dl)
        {
            try
            {
                return new RunningSession_Detail(
                    dl.RunningSessionID,
                    dl.SeqNr,
                    dl.IntervalTime,
                    dl.IntervalSpeed
                   
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapRunningSession_Detail-MapToBL", x);
            }


        }

        public static RunningSession_DetailEF MapToDL(RunningSession_Detail bl)
        {
            try
            {
                return new RunningSession_DetailEF(
                    bl.RunningSessionID,
                    bl.SeqNr,
                    bl.IntervalTime,
                    bl.IntervalSpeed

                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapRunningSession_Detail-MapToDL", x);
            }


        }

    }
}
