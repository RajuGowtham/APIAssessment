using APIAssessment.Models;

namespace APIAssessment.Interfaces
{
    public interface ISessionService
    {
        //create session
        public void CreateSession(Session sess);

        // read Sessions
        public List<Session> GetSessions();

    }
}
