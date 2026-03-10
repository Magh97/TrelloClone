namespace TrelloClone.Domain.Entities;

public class ActivityLog
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Action { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public Guid BoardId { get; set; }
    public Board Board { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}