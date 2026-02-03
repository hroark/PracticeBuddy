namespace PracticeBuddy.Data
{
    public class Session
    {
        #region Properties

        public DateTime SessionCreatedAt { get; set; }

        public string SessionDescription { get; set; } = string.Empty;

        public int SessionId { get; set; }

        public string SessionName { get; set; } = string.Empty;

        public double SessionTotalTimeMinutes { get; set; }

        public SessionStatus Status { get; set; }

        public List<string> Tags { get; set; } = [];

        public List<SessionSteps> Tasks { get; set; } = [];

        public double TotalTimesPlayed { get; set; }

        public DateTime UpdatedAt { get; set; }

        #endregion Properties

        #region Enums

        public enum SessionStatus
        {
            Active,
            Stashed,
            Deleted
        }

        #endregion Enums
    }
}