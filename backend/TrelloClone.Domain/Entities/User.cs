namespace TrelloClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public ICollection<Board> OwnedBoards { get; set; } = new System.Collections.Generic.List<Board>();
        public ICollection<CardMember> CardMembers { get; set; } = new System.Collections.Generic.List<CardMember>();
        public ICollection<BoardMember> BoardMembers { get; set; } = new System.Collections.Generic.List<BoardMember>();
        public ICollection<Comment> Comments { get; set; } = new System.Collections.Generic.List<Comment>();
        public ICollection<ActivityLog> ActivityLogs { get; set; } = new System.Collections.Generic.List<ActivityLog>();
    }
}