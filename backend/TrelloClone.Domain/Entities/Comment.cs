namespace TrelloClone.Domain.Entities;

public class Comment : BaseEntity
{
    public string Content { get; set; } = string.Empty;
    public Guid CardId { get; set; }
    public Card Card { get; set; } = null!;
    public Guid AuthorId { get; set; }
    public User Author { get; set; } = null!;
}