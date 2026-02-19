namespace PracticeBuddy.Models;

public enum Progress
{
    NotStarted,
    InProgress,
    Completed
}

public enum TaskStatus
{
    Active,
    Stashed,
    Deleted
}

/// <summary>
/// A session Step is a single task within a practice routine.
/// </summary>
public class SessionSteps
{
    public int Id { get; set; }
    public Progress Progress { get; set; } = 0;
    public int SesionId { get; set; }
    public TaskStatus Status { get; set; } = 0;
    public int SwapMeetCount { get; set; } = 0;
    public decimal TargetDurationMinutes { get; set; } = 0;

    /// <summary>
    /// Gets or sets the task creation date.
    /// </summary>
    /// <value>
    /// The task creation date.
    /// </value>
    public DateTime TaskCreateDate { get; set; } = DateTime.UtcNow;

    public string TaskDescription { get; set; } = string.Empty;
    public string TaskName { get; set; } = string.Empty;
    public double TaskOrder { get; set; } = 0;
    public double TaskProgressMinutes { get; set; } = 0;

    public void ChangeStatus(TaskStatus newStatus)
    {
        Status = newStatus;
    }

    public void EditTask(string name, string description, decimal targetDuration)
    {
        TaskName = name;
        TaskDescription = description;
        TargetDurationMinutes = targetDuration;
    }

    public void ReorderTask(double newOrder)
    {
        TaskOrder = newOrder;
    }

    public void ResetProgress()
    {
        TaskProgressMinutes = 0;
        Progress = Progress.NotStarted;
    }

    public override string ToString()
    {
        return
            $"Task ID: {Id},Taskorder: {TaskOrder}, Name: {TaskName}, Description: {TaskDescription}, Target Duration: {TargetDurationMinutes} mins, Progress: {TaskProgressMinutes} mins, Status: {Status}, Progress State: {Progress}";
    }

    public void UpdateProgress(decimal minutesPracticed)
    {
        TaskProgressMinutes += (double)minutesPracticed;
        if (TaskProgressMinutes >= (double)TargetDurationMinutes)
        {
            Progress = Progress.Completed;
        }
        else if (TaskProgressMinutes > 0)
        {
            Progress = Progress.InProgress;
        }
    }
}