using APIAssessment.Interfaces;
using APIAssessment.Models;
using APIAssessment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;

        public SessionController(ISessionService service)
        {
            _sessionService = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetSessions()
        {
            var sessions = _sessionService.GetSessions();
            return Ok(sessions);
        }


        [HttpPost]
        public async Task<ActionResult> CreateSession(Session sess)
        {
             _sessionService.CreateSession(sess);
            return CreatedAtAction(nameof(GetSessions), new { id = sess.SessionId }, sess);
        }




    }
}
