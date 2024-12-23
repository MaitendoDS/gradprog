using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.DTO;
using StripsBL.Models;
using StripsBL.Services;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripController : ControllerBase
    {

        StripService _stripService;
        public StripController(StripService stripService)
        {
            _stripService = stripService;
        }

        [Route("Update/{id}")]
        [HttpPut]

        public Strip Update(int id, [FromBody] StripDTO stripDTO)
        {
            Strip strip = new Strip(
                id,
                stripDTO.Titel,
                stripDTO.Nummer,
                stripDTO.Reeks,
                stripDTO.Auteurs,
                stripDTO.Uitgeverij
                );

            return _stripService.Update(strip);
        }


        [Route("GetStripById/{id}")]
        [HttpGet]

        public Strip GetStrip(int id)
        {
            return _stripService.GetStrip(id);
        }


        [Route("GetAll")]
        [HttpGet]

        public List<Strip> GetAll()
        {
            return _stripService.GetAll();
        }


        [Route("Add")]
        [HttpPost]
        public Strip Add([FromBody] StripDTO stripDTO)
        {
            Strip strip = new Strip(
                0,
                stripDTO.Titel,
                stripDTO.Nummer,
                stripDTO.Reeks,
                stripDTO.Auteurs,
                stripDTO.Uitgeverij
                );

            return _stripService.Add(strip);
        }

        [Route("DeleteOrAdd/{id}")]
        [HttpPut]
        public Strip DeleteOrAdd(int stripID, int auteurID)
        {
            return _stripService.DeleteOrAdd(stripID, auteurID);
        }

        [Route("Delete/{id}")]
        [HttpDelete]

        public bool Delete(int id)
        {
            return _stripService.Delete(id);
        }




    }
}
