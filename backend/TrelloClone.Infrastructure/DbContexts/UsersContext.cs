using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Domain.Entities.User>()
            .Property(u => u.Name)
            .HasMaxLength(100);

        modelBuilder.Entity<Domain.Entities.User>()
            .Property(u => u.Email)
            .HasMaxLength(255);

        modelBuilder.Entity<Domain.Entities.User>()
            .Property(u => u.PasswordHash)
            .HasMaxLength(500);
    }
}
