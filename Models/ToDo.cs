namespace netcore_ms_auth.Models;

public enum ToDoStatus {
  Done,
  Started,
  NotStarted
}

public class ToDo {
  public Guid Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public ToDoStatus Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? UpdatedAt { get; set; }
  public Guid CreatedBy { get; set; }
  public Guid? UpdatedBy { get; set; }
}