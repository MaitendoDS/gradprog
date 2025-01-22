using Eindopdracht_PG2_fitness.DTO;
using FitnessBL.Models;
using FitnessBL.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eindopdracht_PG2_fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammaController : ControllerBase
    {
        ProgrammaService _programmaService;

        public ProgrammaController(ProgrammaService programmaService)
        {

            _programmaService = programmaService;

        }

        [HttpPost]

        public Programma Add([FromBody]ProgrammaDTO programmaDTO)
        {

            Programma programma = new Programma();
            programma.ProgramCode = null;
            programma.Name = programmaDTO.Name;
            programma.Target = programmaDTO.Target;
            programma.StartDate = programmaDTO.StartDate;
            programma.MaxMembers = programmaDTO.MaxMembers;

           return _programmaService.Add(programma);           
        }

        [HttpPut]

        public Programma Update(string id, [FromBody] ProgrammaDTO programmaDTO)
        {
            Programma programma = new Programma(
                id,
                programmaDTO.Name,
                programmaDTO.Target,
                programmaDTO.StartDate,
                programmaDTO.MaxMembers
                );

            return _programmaService.Update(programma);
        }




    }
}
