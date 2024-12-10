using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;
using FitnessDL.Models;


namespace FitnessDL.Mappers
{
    public static class MapMember
    {
        public static Member MapToBL(MemberEF dl)
        {
            try
            {
                return new Member(
                    dl.MemberID,
                    dl.FirstName,
                    dl.LastName,
                    dl.Email,
                    dl.Adress,
                    dl.Birthday,
                    dl.Interests??new List<string?>(),
                    dl.MemberType,
                    dl.RunningSessions?.Select(MapRunningSessionMain.MapToBL).ToList() ?? new List<RunningSession_Main>(),
                    dl.Reservations?.Select(MapReservation.MapToBL).ToList() ?? new List<Reservation>(),
                    dl.Programmas?.Select(MapProgramma.MapToBL).ToList() ?? new List<Programma>(),
                    dl.CyclingSessions?.Select(MapCyclingSession.MapToBL).ToList() ?? new List<CyclingSession>()

                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapMember-MapToBL", x);
            }


        }

        public static MemberEF MapToDL(Member bl)
        {
            try
            {
                return new MemberEF(
                    bl.MemberID,
                    bl.FirstName,
                    bl.LastName,
                    bl.Email,
                    bl.Adress,
                    bl.Birthday,
                    bl.Interests ?? new List<string?>(),
                    bl.MemberType,
                    bl.RunningSessions?.Select(MapRunningSessionMain.MapToDL).ToList() ?? new List<RunningSession_MainEF>(),
                    bl.Reservations?.Select(MapReservation.MapToDL).ToList() ?? new List<ReservationEF>(),
                    bl.Programmas?.Select(MapProgramma.MapToDL).ToList() ?? new List<ProgrammaEF>(),
                    bl.CyclingSessions?.Select(MapCyclingSession.MapToDL).ToList() ?? new List<CyclingSessionEF>()

                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapMemberEF-MapToDL", x);
            }


        }


    }
}
