using Eventful.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Eventful.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var events = _context.Events.ToList();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(string id)
        {
            var @event = _context.Events.Find(id);
            return Ok(@event);
        }

    }
}
