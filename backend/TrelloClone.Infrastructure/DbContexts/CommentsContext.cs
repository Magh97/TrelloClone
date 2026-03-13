using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureComments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.Comment>()
            .HasOne(c => c.Card)
            .WithMany(card => card.Comments)
            .HasForeignKey(c => c.CardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.Comment>()
            .HasOne(c => c.Author)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.Comment>()
            .Property(c => c.Content)
            .HasMaxLength(4000);
    }
}
