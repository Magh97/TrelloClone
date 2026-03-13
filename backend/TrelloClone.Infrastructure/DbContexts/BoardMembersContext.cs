using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureBoardMembers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.BoardMember>()
            .HasKey(bm => new { bm.BoardId, bm.UserId });

        modelBuilder.Entity<Domain.Entities.BoardMember>()
            .HasOne(bm => bm.Board)
            .WithMany()
            .HasForeignKey(bm => bm.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.BoardMember>()
            .HasOne(bm => bm.User)
            .WithMany(u => u.BoardMembers)
            .HasForeignKey(bm => bm.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
