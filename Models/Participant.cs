using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace APIAssessment.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Mobile Number Should not Exceed more than 10 characters")]
        public string Phone { get; set; }

        [ForeignKey("Session")]
        public int SessionId { get; set; }
        public List<ParticipantSessions> Sessions { get; set; }

    }
}
