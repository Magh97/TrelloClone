using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureLabels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.Label>()
            .HasOne(l => l.Board)
            .WithMany(b => b.Labels)
            .HasForeignKey(l => l.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.Label>()
            .Property(l => l.Name)
            .HasMaxLength(100);

        modelBuilder.Entity<Domain.Entities.Label>()
            .Property(l => l.Color)
            .HasMaxLength(20);
    }
}
