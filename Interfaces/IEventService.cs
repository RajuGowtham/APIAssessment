using APIAssessment.Models;

namespace APIAssessment.Interfaces
{
    public interface IEventService
    {
        //create event
        public void CreateEvent(Event eve);

        //read events
        public List<Event> GetEvents();

        //update event
        public void UpdateEvent(int eventId, Event eve);

        // delete event
        public void DeleteEvent(int eventId);
    }
}
