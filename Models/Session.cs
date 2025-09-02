using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace APIAssessment.Models
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string Speaker { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public List<ParticipantSessions> Participants { get; set; }
    }
}
