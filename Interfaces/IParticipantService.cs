using APIAssessment.Models;

namespace APIAssessment.Interfaces
{
    public interface IParticipantService
    {
        //create event
        public void CreateParticipant(Participant user);

        //read events
        public List<Participant> GetParticipants();

        //update event
        //public void UpdateParticipant(int eventId);

        // delete event
       // public void DeleteParticipant(int eventId);
    }
}
