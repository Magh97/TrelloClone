using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext: DbContext
{
    private void ConfigureActivityLogs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.ActivityLog>()
            .HasOne(al => al.Board)
            .WithMany(b => b.ActivityLogs)
            .HasForeignKey(al => al.BoardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.ActivityLog>()
            .HasOne(al => al.User)
            .WithMany()
            .HasForeignKey(al => al.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.ActivityLog>()
            .Property(al => al.Action)
            .HasConversion<string>()
            .HasMaxLength(50);
    }
}