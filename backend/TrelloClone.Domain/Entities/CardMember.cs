namespace TrelloClone.Domain.Entities;

public class CardMember
{
    public Guid CardId { get; set; }
    public Card Card { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}