using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureLists(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.List>()
            .HasOne(l => l.Board)
            .WithMany(b => b.Lists)
            .HasForeignKey(l => l.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.List>()
            .HasMany(l => l.Cards)
            .WithOne(c => c.List)
            .HasForeignKey(c => c.ListId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.List>()
            .Property(l => l.Name)
            .HasMaxLength(150);
    }
}
