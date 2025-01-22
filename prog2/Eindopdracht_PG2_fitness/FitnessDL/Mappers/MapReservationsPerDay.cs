using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapReservationsPerDay
    {
        public static ReservationsPerDay MapToBL(ReservationsPerDayEF dl)
        {
            try
            {
                return new ReservationsPerDay(
                    dl.ReservationPerDayID,
                    dl.Date,
                    dl.MemberID,
                    dl.Reservations?.Select(MapReservation.MapToBL).ToList() ?? new List<Reservation>()
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapReservationsPerDay-MapToBL", x);
            }

        }

        public static ReservationsPerDayEF MapToDL(ReservationsPerDay bl)
        {
            try
            {
                return new ReservationsPerDayEF(
                    bl.ReservationPerDayID,
                    bl.Date,
                    bl.MemberID,
                    bl.Reservations?.Select(MapReservation.MapToDL).ToList() ?? new List<ReservationEF>()
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapReservationsPerDay-MapToDL", x);
            }
        }
    }
}
