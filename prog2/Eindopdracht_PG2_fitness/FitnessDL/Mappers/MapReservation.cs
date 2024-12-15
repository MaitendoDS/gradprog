using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapReservation
    {
      public static Reservation MapToBL(ReservationEF dl)
      {
        try
        {
            return new Reservation(
                dl.ReservationID,
                dl.EquipmentID,
                dl.TimeSlotID,
                dl.Date,
                dl.MemberID
                );
        }
        catch (Exception x)
        {

            throw new Exception("MapReservation-MapToBL", x);
        }

      }

        public static ReservationEF MapToDL(Reservation bl)
        {
            try
            {
                return new ReservationEF(
                    bl.ReservationID,
                    bl.EquipmentID,
                    bl.TimeSlotID,
                    bl.Date,
                    bl.MemberID       
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapReservation-MapToDL", x);
            }
        }
    }
}
