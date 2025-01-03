using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.DTO;
using StripsBL.Models;
using StripsBL.Services;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReeksController : ControllerBase
    {

        ReeksService _reeksService;

        public ReeksController(ReeksService reeksService)
        {

            _reeksService = reeksService;

        }


        [Route("GetReeksById/{id}")]
        [HttpGet]

        public IActionResult GetReeks(int id)
        {
            try
            {
                Reeks reeks = new Reeks();
                try
                {
                    reeks = _reeksService.GetReeks(id);

                }
                catch (Exception)
                {

                    return NotFound();
                }
                ReeksDTO reeksDTO = new ReeksDTO();

                reeksDTO.Naam = reeks.ReeksNaam;
                reeksDTO.Nummer = reeks.ReeksID;
                reeksDTO.Url = "https://localhost:7181/api/Reeks/GetReeksById/" + id;

                List<StripReeksDTO> stripReeksDTOList = new List<StripReeksDTO>();

                foreach (var item in reeks.Strips)
                {
                    StripReeksDTO stripReeksDTO = new StripReeksDTO();

                    stripReeksDTO.Titel = item.Titel;
                    stripReeksDTO.Nummer = item.Nummer;
                    stripReeksDTO.Url = "https://localhost:7181/api/Strip/GetStripById/" + item.StripID;

                    stripReeksDTOList.Add(stripReeksDTO);
                }

                reeksDTO.StripReeksDTO = stripReeksDTOList;
                return Ok(reeksDTO);

            }
            catch (Exception)
            {

                return BadRequest();
            }



        }


        [Route("GetAll")]
        [HttpGet]

        public List<Reeks> GetAll()
        {
            return _reeksService.GetAll();
        }


    }
}
