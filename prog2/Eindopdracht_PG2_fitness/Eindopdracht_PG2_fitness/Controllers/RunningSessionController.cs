using FitnessBL.Models;
using FitnessBL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eindopdracht_PG2_fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunningSessionController : ControllerBase
    {

        RunningSessionService _runningSessionService;

        public RunningSessionController(RunningSessionService runningSessionService)
        {
            _runningSessionService = runningSessionService;
        }


        [Route("GetRunningSessionById/{id}")]
        [HttpGet]

        public RunningSession_Main Get(int id)
        {
            return _runningSessionService.Get(id);
        }
    }
}
