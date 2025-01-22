using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Models
{
    public class ReservationsPerDayEF
    {
        public ReservationsPerDayEF()
        {
        }

        public ReservationsPerDayEF(int reservationPerDayID, DateTime date, int memberID, List<ReservationEF> reservations)
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

        public MemberEF Member { get; set; }
        public List<ReservationEF> Reservations { get; set; }

    }
}
