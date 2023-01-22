using Eventful.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Eventful.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;
		public EventsController(IMediator mediator)
		{
			_mediator = mediator;
		}
        

        [HttpGet]
        public IActionResult GetEvents()
        {
			var events = _mediator.Send(new Application.Events.List.Query());
			return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(string id)
        {
            //var @event = _context.Events.Find(id);
            return Ok();
        }

    }
}
