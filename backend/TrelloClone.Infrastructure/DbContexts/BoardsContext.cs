using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureBoards(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.Board>()
            .HasMany(b => b.Lists)
            .WithOne(l => l.Board)
            .HasForeignKey(l => l.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Board>()
            .HasMany(b => b.Labels)
            .WithOne(l => l.Board)
            .HasForeignKey(l => l.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Board>()
            .HasMany(b => b.ActivityLogs)
            .WithOne(al => al.Board)
            .HasForeignKey(al => al.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Domain.Entities.Board>()
            .HasOne(b => b.Owner)
            .WithMany(u => u.OwnedBoards)
            .HasForeignKey(b => b.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}

