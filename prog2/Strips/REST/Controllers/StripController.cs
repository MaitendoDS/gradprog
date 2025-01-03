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
        UitgeverijService _uitgeverijService;
        ReeksService _reeksService;
        AuteurService _auteurService;
        public StripController(StripService stripService,UitgeverijService uitgeverijService, ReeksService reeksService, AuteurService auteurService)
        {
            _stripService = stripService;
            _uitgeverijService = uitgeverijService;
            _reeksService = reeksService;
            _auteurService = auteurService;
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
            getStripDTO.UitgeverijUrl = "https://localhost:7181/api/Uitgeverij/GetUitgeverijById/" + strip.Uitgeverij.UitgeverijID;


            List<AuteurStripDTO> auteurStripDTOList = new List<AuteurStripDTO>();


            foreach (var item in strip.Auteurs)
            {
                AuteurStripDTO auteurStripDTO = new AuteurStripDTO();

                auteurStripDTO.Auteur = item.Naam;
                auteurStripDTO.Url = "https://localhost:7181/api/Auteur/GetAuteurById/" + item.AuteurID;

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
            Uitgeverij uitgeverij = _uitgeverijService.GetUitgeverij(stripDTO.UitgeverijID);
            Reeks reeks = _reeksService.GetReeks(stripDTO.ReeksID);
            List<Auteur> auteurs = new List<Auteur>();
            Auteur auteur = _auteurService.GetAuteur(stripDTO.AuteurID);
            auteurs.Add(auteur);

            Strip strip = new Strip(
                0,
                stripDTO.Titel,
                stripDTO.Nummer,
                reeks,
                auteurs,
                uitgeverij
                );

            return _stripService.Add(strip);
        }
        [Route("Update/{id}")]
        [HttpPut]

        public Strip Update(int id, [FromBody] StripDTO stripDTO)
        {
            Uitgeverij uitgeverij = _uitgeverijService.GetUitgeverij(stripDTO.UitgeverijID);
            Reeks reeks = _reeksService.GetReeks(stripDTO.ReeksID);
            List<Auteur> auteurs = new List<Auteur>();
            

            Strip strip = new Strip(
                id,
                stripDTO.Titel,
                stripDTO.Nummer,
                reeks,
                auteurs,
                uitgeverij
                );

            return _stripService.Update(strip);
        }

        [Route("DeleteOrAddAuteur")]
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
