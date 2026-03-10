namespace TrelloClone.Domain.Entities;

public class Board : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string BackgroundColor { get; set; } = "#FFFFFF";
    public Guid OwnerId { get; set; }
    public User Owner { get; set; } = null!;
    public UserRole Role { get; set; } = UserRole.User;
    public ICollection<List> Lists { get; set; } = new System.Collections.Generic.List<List>();
}