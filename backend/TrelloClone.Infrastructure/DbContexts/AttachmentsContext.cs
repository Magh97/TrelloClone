using Microsoft.EntityFrameworkCore;

namespace TrelloClone.Infrastructure.DbContexts;

public partial class AppDbContext: DbContext
{
    private void ConfigureAttachments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.Attachment>()
            .HasOne(a => a.Card)
            .WithMany(c => c.Attachments)
            .HasForeignKey(a => a.CardId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}