using Microsoft.EntityFrameworkCore;

namespace APIAssessment.Models
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext(DbContextOptions<EventManagementContext> options)
            : base(options)
        {
        }

        // DbSets entities
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<ParticipantSessions> ParticipantSessions { get; set; }

        public DbSet<Event> Events { get; set; }

        // Configure relationships and constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParticipantSessions>()
                .HasKey(ps => new { ps.ParticipantId, ps.SessionId });

            
            modelBuilder.Entity<ParticipantSessions>()
                .HasOne(ps => ps.Participant)
                .WithMany(p => p.Sessions)
                .HasForeignKey(ps => ps.ParticipantId);

            modelBuilder.Entity<ParticipantSessions>()
                .HasOne(ps => ps.Session)
                .WithMany(s => s.Participants)
                .HasForeignKey(ps => ps.SessionId);

        }
            
    }
}