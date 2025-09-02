using System.ComponentModel.DataAnnotations.Schema;

namespace APIAssessment.Models
{
    public class ParticipantSessions
    {
        [ForeignKey("Participant")]
        public int ParticipantId { get; set; }
        public Participant? Participant { get; set; }



        [ForeignKey("Session")]
        public int SessionId { get; set; }

        public Session? Session { get; set; }
    }
}
