using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapRunningSessionMain
    {
        public static RunningSession_Main MapToBL(RunningSession_MainEF dl)
        {
            try
            {
                return new RunningSession_Main(
                    dl.RunningSessionID,
                    dl.Date,
                    dl.MemberID,
                    dl.Duration,
                    dl.AvgSpeed,
                    dl.RunningSession_Details != null ? MapRunningSessionDetail.MapToBL(dl.RunningSession_Details) : new RunningSession_Detail()

                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapRunningSession_Main-MapToBL", x);
            }


        }

        public static RunningSession_MainEF MapToDL(RunningSession_Main bl)
        {
            try
            {
                return new RunningSession_MainEF(
                    bl.RunningSessionID,
                    bl.Date,
                    bl.MemberID,
                    bl.Duration,
                    bl.AvgSpeed,
                    bl.RunningSession_Details != null ? MapRunningSessionDetail.MapToDL(bl.RunningSession_Details) : new RunningSession_DetailEF()


                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapRunningSession_Main-MapToDL", x);
            }


        }


    }
}
