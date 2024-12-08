using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        [Key]
        public int ReservationID { get; set; }
        public Equipment EquipmentID { get; set; }
        public Time_Slot TimeSlotID { get; set; }
        public DateOnly Date { get; set; }
        public Members MemberID { get; set; }


    }
}
