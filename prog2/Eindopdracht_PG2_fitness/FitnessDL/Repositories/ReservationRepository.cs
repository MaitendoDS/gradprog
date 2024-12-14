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
    public class ReservationRepository: IReservationRepository
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
