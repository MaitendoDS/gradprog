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


        public Reservation Add(Reservation reservation)
        {


            try
            {

                return _reservationRepository.Add(reservation);
            }
            catch (Exception x)
            {

                throw new Exception("ReservationService-Add", x);
            }
        }

        public Reservation Update(Reservation reservation)
        {


            try
            {

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
