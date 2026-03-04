using PracticeBuddy;

namespace PracticeBuddy.Data
{
    public class SessionBase
    {
        public string SessionDescription { get; set; } = string.Empty;
        public string SessionName { get; set; } = string.Empty;
        public Progress Status { get; set; }
        public List<string> Tags { get; set; } = new();
        /// <summary>
        /// Gets or sets the task creation date.
        /// </summary>
        /// <value>
        /// The task creation date.
        /// </value>
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public decimal DurationMinutes { get; set; } = 0;
    }
}