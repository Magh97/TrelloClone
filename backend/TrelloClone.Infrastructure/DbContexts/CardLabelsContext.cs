using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext : DbContext
{
    private void ConfigureCardLabels(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.CardLabel>()
            .HasKey(cl => new { cl.CardId, cl.LabelId });

        modelBuilder.Entity<Domain.Entities.CardLabel>()
            .HasOne(cl => cl.Card)
            .WithMany(c => c.CardLabels)
            .HasForeignKey(cl => cl.CardId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Domain.Entities.CardLabel>()
            .HasOne(cl => cl.Label)
            .WithMany(l => l.CardLabels)
            .HasForeignKey(cl => cl.LabelId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
