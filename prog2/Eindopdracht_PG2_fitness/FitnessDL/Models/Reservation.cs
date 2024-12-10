using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDL.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(int equipmentID, Equipment equipment, int timeSlotID, Time_Slot timeSlot, DateTime date, int memberID, Member member)
        {
            EquipmentID = equipmentID;
            Equipment = equipment;
            TimeSlotID = timeSlotID;
            TimeSlot = timeSlot;
            Date = date;
            MemberID = memberID;
            Member = member;
        }

        public Reservation(int reservationID, int equipmentID, Equipment equipment, int timeSlotID, Time_Slot timeSlot, DateTime date, int memberID, Member member)
        {
            ReservationID = reservationID;
            EquipmentID = equipmentID;
            Equipment = equipment;
            TimeSlotID = timeSlotID;
            TimeSlot = timeSlot;
            Date = date;
            MemberID = memberID;
            Member = member;
        }

        [Key]
        public int ReservationID { get; set; }

        public int EquipmentID { get; set; }

        public Equipment Equipment { get; set; }

        public int TimeSlotID { get; set; }

        public Time_Slot TimeSlot { get; set; }

        public DateTime Date { get; set; }

        public int MemberID { get; set; }

        public Member Member { get; set; }
    }
}
