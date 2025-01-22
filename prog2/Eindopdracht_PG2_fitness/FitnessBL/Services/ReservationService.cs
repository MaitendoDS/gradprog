using FitnessBL.DTO;
using FitnessBL.Interfaces;
using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Services
{
    public class ReservationService
    {

        IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {

            _reservationRepository = reservationRepository;
        }


        public void Add(ReservationsPerDayDTO reservationsPerDayDTO)
        {

            if (
                (reservationsPerDayDTO.EquipmentID1 == 0 && reservationsPerDayDTO.TimeSlotID1 == 0) &&
                (reservationsPerDayDTO.EquipmentID2 == 0 && reservationsPerDayDTO.TimeSlotID2 == 0) &&
                (reservationsPerDayDTO.EquipmentID3 == 0 && reservationsPerDayDTO.TimeSlotID3 == 0) &&
                (reservationsPerDayDTO.EquipmentID4 == 0 && reservationsPerDayDTO.TimeSlotID4 == 0)
               )
            {
                throw new Exception("ongeldige reservatie...");
            }

            ReservationsPerDay reservationsPerDay = new ReservationsPerDay();
            reservationsPerDay.MemberID = reservationsPerDayDTO.MemberID;
            reservationsPerDay.Date = reservationsPerDayDTO.Date;
            reservationsPerDay.ReservationPerDayID = 0;

            List<Reservation> reservationsList = new List<Reservation>();

            if (reservationsPerDayDTO.EquipmentID1 != 0 || reservationsPerDayDTO.TimeSlotID1 != 0)
            {
                Reservation reservation = new Reservation();
                reservation.ReservationID = 0;
                reservation.MemberID = reservationsPerDayDTO.MemberID;
                reservation.Date = reservationsPerDayDTO.Date;
                reservation.TimeSlotID = reservationsPerDayDTO.TimeSlotID1;
                reservation.EquipmentID = reservationsPerDayDTO.EquipmentID1;
                reservationsList.Add(reservation);
            }
            if (reservationsPerDayDTO.EquipmentID2 != 0 || reservationsPerDayDTO.TimeSlotID2 != 0)
            {
                Reservation reservation = new Reservation();
                reservation.ReservationID = 0;
                reservation.MemberID = reservationsPerDayDTO.MemberID;
                reservation.Date = reservationsPerDayDTO.Date;
                reservation.TimeSlotID = reservationsPerDayDTO.TimeSlotID2;
                reservation.EquipmentID = reservationsPerDayDTO.EquipmentID2;
                reservationsList.Add(reservation);
            }
            if (reservationsPerDayDTO.EquipmentID3 != 0 || reservationsPerDayDTO.TimeSlotID3 != 0)
            {
                Reservation reservation = new Reservation();
                reservation.ReservationID = 0;
                reservation.MemberID = reservationsPerDayDTO.MemberID;
                reservation.Date = reservationsPerDayDTO.Date;
                reservation.TimeSlotID = reservationsPerDayDTO.TimeSlotID3;
                reservation.EquipmentID = reservationsPerDayDTO.EquipmentID3;
                reservationsList.Add(reservation);
            }
            if (reservationsPerDayDTO.EquipmentID4 != 0 || reservationsPerDayDTO.TimeSlotID4 != 0)
            {
                Reservation reservation = new Reservation();
                reservation.ReservationID = 0;
                reservation.MemberID = reservationsPerDayDTO.MemberID;
                reservation.Date = reservationsPerDayDTO.Date;
                reservation.TimeSlotID = reservationsPerDayDTO.TimeSlotID4;
                reservation.EquipmentID = reservationsPerDayDTO.EquipmentID4;
                reservationsList.Add(reservation);
            }
            reservationsPerDay.Reservations = reservationsList;

            List<Reservation> reservaties = new List<Reservation>();

            foreach (var reservation in reservationsList)
            {




                (var equipment, var timeslot, var reservations, var equipmentlist, var equipmentListMember, var timeslots) = _reservationRepository.ReservationInfoProvider(reservation);

                if (reservation == null)
                {
                    throw new Exception("Reservation is null");
                }

                if (reservation.Date >= DateTime.Now.AddDays(7))
                {
                    throw new Exception("Mag niet meer dan 7 dagen in de toekomst zijn");
                }

                if (reservaties.Count > 0)
                {
                    foreach (var res in reservaties)
                    {
                        reservations.Add(res);

                        if (reservation.EquipmentID == res.EquipmentID)
                        {
                            equipmentlist.Add(res);
                            equipmentListMember.Add(res);
                            timeslots.Add(_reservationRepository.GetTimeSlot(res.TimeSlotID));
                        }

                    }
                }

                if (equipment == null)
                {
                    throw new Exception("Equipment is null");
                }
                if (equipment.InRepair)
                {
                    throw new Exception("Toestel is in service");
                }

                if (timeslot == null)
                {
                    throw new Exception("TimeSlot is null");
                }

                if (reservations.Count >= 4)
                {
                    throw new Exception("Meer dan 4 reservaties al deze dag");
                }

                if (equipmentlist.Any(e => e.TimeSlotID == reservation.TimeSlotID))
                {
                    throw new Exception("Toestel al in gebruik");
                }

                timeslots.Add(timeslot);
                timeslots = timeslots.OrderBy(t => t.StartTime).ToList();

                for (int i = 0; i < timeslots.Count - 2; i++)
                {
                    if (timeslots[i + 1].TimeSlotID - timeslots[i].TimeSlotID == 1 && timeslots[i + 2].TimeSlotID - timeslots[i + 1].TimeSlotID == 1)
                    {
                        throw new Exception("Mag maar 2 slots na elkaar met zelfde toestel");
                    }

                }
                reservaties.Add(reservation);
            }
             _reservationRepository.Add(reservationsPerDay);

        }

        public ReservationsPerDay Get(int id)
        {

            return _reservationRepository.Get(id);
        }

        public Reservation Update(Reservation reservation)
        {
            try
            {

                (var equipment, var timeslot, var reservations, var equipmentlist, var equipmentListMember, var timeslots) = _reservationRepository.ReservationInfoProvider(reservation);

                if (reservation == null)
                {
                    throw new Exception("Reservation is null");
                }

                if (reservation.Date >= DateTime.Now.AddDays(7))
                {
                    throw new Exception("Mag niet meer dan 7 dagen in de toekomst zijn");
                }

                if (equipment == null)
                {
                    throw new Exception("Equipment is null");
                }
                if (equipment.InRepair)
                {
                    throw new Exception("Toestel is in service");
                }

                if (timeslot == null)
                {
                    throw new Exception("TimeSlot is null");
                }


                if (equipmentlist.Any(e => e.TimeSlotID == reservation.TimeSlotID))
                {
                    throw new Exception("Toestel al in gebruik");
                }

                timeslots.Add(timeslot);
                timeslots = timeslots.OrderBy(t => t.StartTime).ToList();

                for (int i = 0; i < timeslots.Count - 2; i++)
                {
                    if (timeslots[i + 1].TimeSlotID - timeslots[i].TimeSlotID == 1 && timeslots[i + 2].TimeSlotID - timeslots[i + 1].TimeSlotID == 1)
                    {
                        throw new Exception("Mag maar 2 slots na elkaar met zelfde toestel");
                    }

                }
                return _reservationRepository.Update(reservation);
            }
            catch (Exception x)
            {

                throw new Exception("ReservationService-Update", x);
            }
        }
        public bool Delete(int id)
        {
            try
            {


                _reservationRepository.Delete(id);

                return true;
            }
            catch (Exception x)
            {

                throw new Exception("ReservationService-Delete", x);
            }
        }


    }
}
