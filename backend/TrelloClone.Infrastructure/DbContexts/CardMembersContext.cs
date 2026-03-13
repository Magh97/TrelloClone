using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureCardMembers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.CardMember>()
            .HasKey(cm => new { cm.CardId, cm.UserId });

        modelBuilder.Entity<Domain.Entities.CardMember>()
            .HasOne(cm => cm.Card)
            .WithMany(c => c.CardMembers)
            .HasForeignKey(cm => cm.CardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.CardMember>()
            .HasOne(cm => cm.User)
            .WithMany(u => u.CardMembers)
            .HasForeignKey(cm => cm.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
