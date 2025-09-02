using APIAssessment.Interfaces;
using APIAssessment.Models;
using APIAssessment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult> GetEvents()
        {
            var events = _eventService.GetEvents();
            return Ok(events);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEvent(Event eve)
        {
            _eventService.CreateEvent(eve);
            return CreatedAtAction(nameof(GetEvents), new { id = eve.EventId }, eve);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEvent(int eventId)
        {
            _eventService.DeleteEvent(eventId);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEvent(int eventId, Event eve)
        {
            _eventService.UpdateEvent(eventId, eve);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEventById(int id)
        {
            var events = _eventService.GetEvents();
            var eve = events.FirstOrDefault(e => e.EventId == id);
            if (eve == null)
            {
                return NotFound();
            }
            return Ok(eve);
        }

    }
}
