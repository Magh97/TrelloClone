namespace TrelloClone.Domain.Entities;

public class Card : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid ListId { get; set; }
    public List List { get; set; } = null!;
    public int Order { get; set; } = 0;
    public DateTime? DueDate { get; set; } = null;

    public ICollection<CardMember> CardMembers { get; set; } = new List<CardMember>();
    public ICollection<CardLabel> CardLabels { get; set; } = new List<CardLabel>();
}