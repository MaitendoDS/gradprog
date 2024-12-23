using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StripsBL.Models;
using StripsBL.Interfaces;
using StripsBL.Services;
using REST.DTO;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UitgeverijController : ControllerBase
    {

        UitgeverijService _uitgeverijService;

        public UitgeverijController(UitgeverijService uitgeverijService)
        {

            _uitgeverijService = uitgeverijService;

        }


        [Route("Update/{id}")]
        [HttpPut]


        public Uitgeverij Update(int id, [FromBody] UitgeverijDTO uitgeverijDTO)
        {
            Uitgeverij uitgeverij = new Uitgeverij(
                id,
                uitgeverijDTO.Naam,
                uitgeverijDTO.Adres
                );

            return _uitgeverijService.Update(uitgeverij);
        }

    }
}
