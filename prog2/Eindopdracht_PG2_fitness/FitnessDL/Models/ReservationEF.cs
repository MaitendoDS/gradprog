using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDL.Models
{
    public class ReservationEF
    {
        public ReservationEF()
        {
        }

        public ReservationEF(int reservationID, int equipmentID, int timeSlotID, DateTime date, int memberID)
        {
            ReservationID = reservationID;
            EquipmentID = equipmentID;
            TimeSlotID = timeSlotID;
            Date = date;
            MemberID = memberID;
        }

        public ReservationEF(int reservationID, int equipmentID, int timeSlotID, DateTime date, int memberID, EquipmentEF equipment, Time_SlotEF timeSlot)
        {
            ReservationID = reservationID;
            EquipmentID = equipmentID;
            TimeSlotID = timeSlotID;
            Date = date;
            MemberID = memberID;
            Equipment = equipment;
            TimeSlot = timeSlot;
        }

        [Key]
        public int ReservationID { get; set; }
        public int EquipmentID { get; set; }
        public int TimeSlotID { get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }

        public MemberEF Member { get; set; }
        public EquipmentEF Equipment { get; set; }
        public Time_SlotEF TimeSlot { get; set; }
    }
}
