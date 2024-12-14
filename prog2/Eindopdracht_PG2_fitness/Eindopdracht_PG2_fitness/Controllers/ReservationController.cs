using Eindopdracht_PG2_fitness.DTO;
using FitnessBL.Models;
using FitnessBL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eindopdracht_PG2_fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {

            _reservationService = reservationService;

        }

        [Route("Add Reservation")]
        [HttpPost]

        public Reservation Add([FromBody] ReservationDTO reservationDTO)
        {
            Reservation reservation = new Reservation();
            reservation.ReservationID = 0;
            reservation.EquipmentID = reservationDTO.EquipmentID;
            reservation.TimeSlotID = reservationDTO.TimeSlotID;
            reservation.Date = reservationDTO.Date;
            reservation.MemberID = reservationDTO.MemberID;

            return _reservationService.Add(reservation);
        }

        [Route("Update Reservation")]
        [HttpPut]

        public Reservation Update(int id, [FromBody] ReservationDTO reservationDTO)
        {
            Reservation reservation = new Reservation();

            reservation.ReservationID = id;
            reservation.EquipmentID = reservationDTO.EquipmentID;
            reservation.TimeSlotID = reservationDTO.TimeSlotID;
            reservation.Date = reservationDTO.Date;
            reservation.MemberID = reservationDTO.MemberID;

            return _reservationService.Update(reservation);
        }

        [Route("Delete/{id}")]
        [HttpDelete]

        public bool Delete(int id)
        {
            return _reservationService.Delete(id);
        }


    }
}
