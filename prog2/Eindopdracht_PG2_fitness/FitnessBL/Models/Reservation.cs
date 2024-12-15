using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessBL.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(int reservationID, int equipmentID, int timeSlotID, DateTime date, int memberID)
        {
            ReservationID = reservationID;
            EquipmentID = equipmentID;
            TimeSlotID = timeSlotID;
            Date = date;
            MemberID = memberID;
        }

        public Reservation(int reservationID, int equipmentID, int timeSlotID, DateTime date, int memberID, Equipment equipment, Time_Slot timeSlot)
        {
            ReservationID = reservationID;
            EquipmentID = equipmentID;
            TimeSlotID = timeSlotID;
            Date = date;
            MemberID = memberID;
            Equipment = equipment;
            TimeSlot = timeSlot;
        }

        public int ReservationID { get; set; }
        public int EquipmentID { get; set; }
        public int TimeSlotID { get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }

        public Equipment Equipment { get; set; }
        public Time_Slot TimeSlot { get; set; }
  
    }
}
