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

        public GetStripDTO GetStrip(int id)
        {
            Strip strip = _stripService.GetStrip(id);
            GetStripDTO getStripDTO = new GetStripDTO();




            getStripDTO.Url = "https://localhost:7181/api/Strip/GetStripById/" + id;
            getStripDTO.Titel = strip.Titel;
            getStripDTO.Nummer = strip.Nummer;
            getStripDTO.Reeks = strip.ReeksNaam;
            getStripDTO.ReeksUrl = "https://localhost:7181/api/Reeks/GetReeksById/" + strip.ReeksNummer;
            getStripDTO.Uitgeverij = strip.Uitgeverij.Naam;
            getStripDTO.UitgeverijUrl = "hier url in" + strip.Uitgeverij.UitgeverijID;


            List<AuteurStripDTO> auteurStripDTOList = new List<AuteurStripDTO>();


            foreach (var item in strip.Auteurs)
            {
                AuteurStripDTO auteurStripDTO = new AuteurStripDTO();

                auteurStripDTO.Auteur = item.Naam;
                auteurStripDTO.Url = "url hierrr" + id;

                auteurStripDTOList.Add(auteurStripDTO);

            }
                getStripDTO.AuteurStripDTO = auteurStripDTOList;

            return getStripDTO;



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
