using Eindopdracht_PG2_fitness.DTO;
using FitnessBL.Models;
using FitnessBL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eindopdracht_PG2_fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        EquipmentService _equipmentService;

        public EquipmentController(EquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }


        [Route("Add")]
        [HttpPost]

        public Equipment Add([FromBody] EquipmentDTO equipmentDTO)
        {
            
            Equipment equipment = new Equipment();

            equipment.EquipmentID = 0;
            equipment.DeviceType = equipmentDTO.DeviceType;
            equipment.InRepair = equipmentDTO.InRepair;

            return _equipmentService.Add(equipment);
        }

        [Route("RepairingOnOff/{id}")]
        [HttpPut]

        public Equipment Repairing(int id)
        {
            return _equipmentService.Repairing(id);
        }


    }
}
