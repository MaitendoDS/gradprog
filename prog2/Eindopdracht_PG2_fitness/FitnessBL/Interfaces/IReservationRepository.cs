using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Interfaces
{
    public interface IReservationRepository
    {
        public (Equipment equipment, Time_Slot timeslot, List<Reservation> reservations, List<Reservation> equipmentlist, List<Reservation> equipmentListMember, List<Time_Slot> timeslots) ReservationInfoProvider(Reservation reservation);
        public void Add(ReservationsPerDay reservationsPerDay);
        public Time_Slot GetTimeSlot(int id);
        public Reservation Update(Reservation reservation);
        public bool Delete(int id);
        public ReservationsPerDay Get(int id);

    }
}
