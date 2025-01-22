using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Models
{
    public class ReservationsPerDay
    {
        public ReservationsPerDay()
        {
        }

        public ReservationsPerDay(int reservationPerDayID, DateTime date, int memberID, List<Reservation> reservations)
        {
            ReservationPerDayID = reservationPerDayID;
            Date = date;
            MemberID = memberID;
            Reservations = reservations;
        }

        [Key]
        public int ReservationPerDayID { get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }

        public List<Reservation> Reservations { get; set; }

    }
}
