using APIAssessment.Interfaces;
using APIAssessment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Participant>>> GetParticipants()
        {
            var participants = _participantService.GetParticipants();
            return Ok(participants);
        }

        [HttpPost]
        public async Task<ActionResult<Participant>> CreateParticipant([FromBody] Participant participant)
        {

            _participantService.CreateParticipant(participant);

            return CreatedAtAction(nameof(GetParticipants), new { id = participant.ParticipantId }, participant);
        }
    }
}
