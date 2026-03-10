namespace TrelloClone.Domain.Entities;

public class Attachment: BaseEntity
{
    public string FileName { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public Guid CardId { get; set; }
    public Card Card { get; set; } = null!;
}