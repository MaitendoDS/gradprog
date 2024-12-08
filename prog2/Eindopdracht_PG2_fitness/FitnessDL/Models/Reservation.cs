using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessDL.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        [Key]
        public int ReservationID { get; set; }

        [Required]
        public int EquipmentID { get; set; } // foreign key
        [ForeignKey("EquipmentID")]
        public Equipment Equipment { get; set; } // navigation property

        [Required]
        public int TimeSlotID { get; set; } // foreign key
        [ForeignKey("TimeSlotID")]
        public Time_Slot TimeSlot { get; set; } //NAvigation property

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int MemberID { get; set; } //foreign key
        [ForeignKey("MemberID")]
        public Member Member { get; set; } // navigation property
    }
}
