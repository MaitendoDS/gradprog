using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventsTest.Models; //als hij mn klasse van bij models niet kan zien moet ik dit toevoegen

namespace EventsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IEventRepository repo;
        public EventController(IEventRepository repo)
        {
            this.repo = repo;
        }  // repo aanmaken ^
        [HttpGet]
        //[HttpHead]

        public ActionResult<Event> GetAll()
        {
            try
            {
                return Ok(repo.GetAll());
            }
            catch (EventExceptions ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{Name}")]
        //[HttpHead("{Name}")]

      

        public ActionResult<Event> Get(int id)
        {
            try
            {
                return Ok(repo.GetEvent(id));
            }
            catch (EventExceptions ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{Name}")]


        [HttpDelete]

     

        public bool Delete(int id)
        {
            try
            {
                repo.RemoveEvent(repo.GetEvent(id));
                return true;         //bro ik return nu wel iets, niet skeer volgens dean !!! 
            }
            catch (EventExceptions ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<Event> Post([FromBody] Event @event)
        {
            repo.AddEvent(@event);
            return CreatedAtAction(nameof(Get), new { id = @event.Id }, @event);
        }


        // hieronder is om te filteren vvvvvvvv

        //[httpget]
        //[httphead]
        //public ienumerable<country> getall([fromquery] string continent, [fromquery] string capital)
        //{
        //    if (!string.isnullorwhitespace(continent) && !string.isnullorwhitespace(capital))
        //    {
        //        return repo.getall(continent);
        //    }
        //    return repo.getall();
        //}
        //[httppost]
        //public actionresult<country> post([frombody] country country)
        //{
        //    repo.addcountry(country);
        //    return createdataction(nameof(get), new { id = country.id }, country);
        //}



    }
}
