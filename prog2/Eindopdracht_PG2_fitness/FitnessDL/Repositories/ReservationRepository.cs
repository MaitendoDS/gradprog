using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessDL.Mappers;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Repositories
{
    public class ReservationRepository : IReservationRepository
    {

        FitnessContext _context;
        public ReservationRepository(FitnessContext context)
        {
            _context = context;

        }

        public Reservation Add(Reservation reservation)
        {

            try
            {
                if (reservation == null)
                {
                    throw new Exception("Reservation is null");
                }

                var reservationEF = MapReservation.MapToDL(reservation);

                if (reservation.Date >= DateTime.Now.AddDays(7))
                {
                    throw new Exception("Mag niet meer dan 7 dagen in de toekomst zijn");
                }


                var equipment = _context.Equipment.FirstOrDefault(e => e.EquipmentID == reservation.EquipmentID);
                if (equipment == null)
                {
                    throw new Exception("Equipment is null");
                }

                var timeslot = _context.Time_Slot.FirstOrDefault(e => e.TimeSlotID == reservation.TimeSlotID);
                if (timeslot == null)
                {
                    throw new Exception("TimeSlot is null");
                }

                List<ReservationEF> reservations = _context.Reservations.Where(r => r.MemberID == reservation.MemberID && r.Date.Date == reservation.Date.Date).ToList();

                if (reservations.Count >= 4)
                {
                    throw new Exception("Meer dan 4 reservaties al deze dag");
                }

                List<ReservationEF> equipmentlist = _context.Reservations.Where(e => e.EquipmentID == reservation.EquipmentID && e.Date.Date == reservation.Date.Date).ToList();

                if (equipmentlist.Any(e => e.TimeSlotID == reservation.TimeSlotID))
                {
                    throw new Exception("Toestel al in gebruik");
                }

               
                List<ReservationEF> equipmentListMember = _context.Reservations.Where(e => e.EquipmentID == reservation.EquipmentID && e.Date.Date == reservation.Date.Date && e.MemberID == reservation.MemberID).ToList();
                List<Time_SlotEF> timeSlots = equipmentListMember.Select(e => _context.Time_Slot.FirstOrDefault(t => t.TimeSlotID == e.TimeSlotID)).ToList();

                timeSlots.Add(timeslot);
                timeSlots = timeSlots.OrderBy(t => t.StartTime).ToList();

                for(int i = 0;i < timeSlots.Count -2;i++)
                {
                    if (timeSlots[i+1].TimeSlotID - timeSlots[i].TimeSlotID == 1 && timeSlots[i+2].TimeSlotID - timeSlots[i+1].TimeSlotID == 1)
                    {
                        throw new Exception("Mag maar 2 slots na elkaar met zelfde toestel");
                    }
                    
                }

                _context.Reservations.Add(reservationEF);
                _context.SaveChanges();

                return MapReservation.MapToBL(reservationEF);

















            }
            catch (Exception x)
            {

                throw new Exception("ReservationRepository-Add", x);
            }

        }

        public Reservation Update(Reservation reservation)
        {

            try
            {
                ReservationEF reservationEF = _context.Reservations.Find(reservation.ReservationID);

                if (reservationEF != null)
                {
                    _context.Entry(reservationEF).CurrentValues.SetValues(MapReservation.MapToDL(reservation));// entry is heel het rijtje in db
                    _context.SaveChanges();

                    return MapReservation.MapToBL(reservationEF); //return terug een normale reservation ipv reservationEF

                }
                else
                {
                    throw new Exception("Reservation niet gevonden"); 
                }




            }
            catch (Exception x)
            {

                throw new Exception("ReservationRepository-Update", x);
            }

        }

        public bool Delete(int id)
        {

            try
            {
                ReservationEF reservationEF = new ReservationEF(); // zodat ef naar ID kan kijken en dan de reserv met dezlfde id vverwijderen
                reservationEF.ReservationID = id;
                _context.Remove(reservationEF);

                _context.SaveChanges();

                return true;

            }
            catch (Exception x)
            {

                throw new Exception("ReservationRepository-Delete", x);
            }
        }



    }
}
