using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessDL.Mappers;
using FitnessDL.Models;
using Microsoft.EntityFrameworkCore;
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

        public Time_Slot GetTimeSlot(int id)
        {
            var timeslotEF= _context.Time_Slot.FirstOrDefault(t => t.TimeSlotID == id);
            return MapTimeSlot.MapToBL(timeslotEF);
        }

        public (Equipment equipment, Time_Slot timeslot, List<Reservation> reservations, List<Reservation> equipmentlist, List<Reservation> equipmentListMember, List<Time_Slot> timeslots) ReservationInfoProvider(Reservation reservation)
        {

            var equipmentEF = _context.Equipment.FirstOrDefault(e => e.EquipmentID == reservation.EquipmentID);
            var timeslotEF = _context.Time_Slot.FirstOrDefault(e => e.TimeSlotID == reservation.TimeSlotID);

            List<ReservationEF> reservationsEF = _context.Reservations.Where(r => r.MemberID == reservation.MemberID && r.Date.Date == reservation.Date.Date).ToList();
            List<ReservationEF> equipmentlistEF = _context.Reservations.Where(e => e.EquipmentID == reservation.EquipmentID && e.Date.Date == reservation.Date.Date).ToList();

            List<ReservationEF> equipmentListMemberEF = _context.Reservations.Where(e => e.EquipmentID == reservation.EquipmentID && e.Date.Date == reservation.Date.Date && e.MemberID == reservation.MemberID).ToList();
            List<Time_SlotEF> timeSlotsEF = equipmentListMemberEF.Select(e => _context.Time_Slot.FirstOrDefault(t => t.TimeSlotID == e.TimeSlotID)).ToList();

            var equipment = equipmentEF != null ? MapEquipment.MapToBL(equipmentEF) : null;
            var timeslot = timeslotEF != null ? MapTimeSlot.MapToBL(timeslotEF) : null;
            var reservations = reservationsEF.Select(MapReservation.MapToBL).ToList();
            var equipmentlist = equipmentlistEF.Select(MapReservation.MapToBL).ToList();
            var equipmentListMember = equipmentListMemberEF.Select(MapReservation.MapToBL).ToList();

            var timeslots = equipmentListMemberEF
                .Select(r => _context.Time_Slot.FirstOrDefault(t => t.TimeSlotID == r.TimeSlotID))
                .Where(t => t != null)
                .Select(MapTimeSlot.MapToBL)
                .ToList();

            return (equipment, timeslot, reservations, equipmentlist, equipmentListMember, timeslots);
        }

        public ReservationsPerDay Get(int id)
        {
            try
            {
                var reservationsPerDay = _context.ReservationsPerDay
                    .Include(m => m.Reservations)
                    .FirstOrDefault(m => m.ReservationPerDayID == id);

                return reservationsPerDay != null ? MapReservationsPerDay.MapToBL(reservationsPerDay) : throw new Exception("Reservation is null");
            }
            catch (Exception x)
            {

                throw new Exception("ReservationsRepository-Get", x);
            }
        }

        public void Add(ReservationsPerDay reservationsPerDay)
        {
            try
            {
                var reservationEF = MapReservationsPerDay.MapToDL(reservationsPerDay);

                _context.ReservationsPerDay.Add(reservationEF);
                _context.SaveChanges();

                
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
