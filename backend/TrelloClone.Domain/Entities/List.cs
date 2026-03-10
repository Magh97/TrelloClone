namespace TrelloClone.Domain.Entities;

public class List : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Guid BoardId { get; set; }
    public Board Board { get; set; } = null!;
    public int Order { get; set; } = 0;
    public ICollection<Card> Cards { get; set; } = new List<Card>();
}