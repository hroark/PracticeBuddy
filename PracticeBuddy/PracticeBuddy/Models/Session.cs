using PracticeBuddy.Models;
using PracticeBuddy;

namespace PracticeBuddy.Data
{
    public class Session : SessionBase
    {

        public DateTime SessionCreatedAt { get; set; }
        public int SessionId { get; set; }
        public double SessionTotalTimeMinutes { get; set; }
        public List<SessionSteps> Tasks { get; set; } = new();
        public double TotalTimesPlayed { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}