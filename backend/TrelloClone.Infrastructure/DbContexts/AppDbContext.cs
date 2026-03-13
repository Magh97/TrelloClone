using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext: DbContext
{
    public DbSet<Domain.Entities.ActivityLog> ActivityLogs { get; set; } = null!;
    public DbSet<Domain.Entities.Attachment> Attachments { get; set; } = null!;
    public DbSet<Domain.Entities.Board> Boards { get; set; } = null!;
    public DbSet<Domain.Entities.BoardMember> BoardMembers { get; set; } = null!;
    public DbSet<Domain.Entities.Card> Cards { get; set; } = null!;
    public DbSet<Domain.Entities.CardLabel> CardLabels { get; set; } = null!;
    public DbSet<Domain.Entities.CardMember> CardMembers { get; set; } = null!;
    public DbSet<Domain.Entities.Comment> Comments { get; set; } = null!;
    public DbSet<Domain.Entities.Label> Labels { get; set; } = null!;
    public DbSet<Domain.Entities.List> Lists { get; set; } = null!;
    public DbSet<Domain.Entities.User> Users { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ConfigureActivityLogs(modelBuilder);
        ConfigureAttachments(modelBuilder);
        ConfigureBoards(modelBuilder);
        ConfigureBoardMembers(modelBuilder);
        ConfigureCards(modelBuilder);
        ConfigureCardLabels(modelBuilder);
        ConfigureCardMembers(modelBuilder);
        ConfigureComments(modelBuilder);
        ConfigureLabels(modelBuilder);
        ConfigureLists(modelBuilder);
        ConfigureUsers(modelBuilder);
    }
}