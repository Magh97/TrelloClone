namespace TrelloClone.Domain.Entities;

public class Label : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Color { get; set; } = null!;
    public Guid BoardId { get; set; }
    public Board Board { get; set; } = null!;

    public ICollection<CardLabel> CardLabels { get; set; } = new List<CardLabel>();
}