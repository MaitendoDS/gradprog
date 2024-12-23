using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.DTO;
using StripsBL.Models;
using StripsBL.Services;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuteurController : ControllerBase
    {

        AuteurService _auteurService;

        public AuteurController(AuteurService auteurService)
        {

            _auteurService = auteurService;

        }


        [Route("Update/{id}")]
        [HttpPut]

        public Auteur Update(int id, [FromBody] AuteurDTO auteurDTO)
        {
            Auteur auteur = new Auteur(
                id,
                auteurDTO.Naam,
                auteurDTO.Email
                );

            return _auteurService.Update(auteur);
        }

    }
}
