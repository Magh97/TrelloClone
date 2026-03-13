using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext: DbContext
{
    private void ConfigureCards(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.Card>()
            .HasMany(c => c.Attachments)
            .WithOne(a => a.Card)
            .HasForeignKey(a => a.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Card>()
            .HasMany(c => c.Comments)
            .WithOne(cm => cm.Card)
            .HasForeignKey(cm => cm.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Card>()
            .HasMany(c => c.CardMembers)
            .WithOne(cm => cm.Card)
            .HasForeignKey(cm => cm.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Card>()
            .HasMany(c => c.CardLabels)
            .WithOne(cl => cl.Card)
            .HasForeignKey(cl => cl.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Card>()
            .HasOne(c => c.List)
            .WithMany(l => l.Cards)
            .HasForeignKey(c => c.ListId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}