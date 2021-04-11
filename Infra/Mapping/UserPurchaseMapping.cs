using ComicStoreApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicStoreApi.Infra.Mapping
{
    public class UserPurchaseMapping : IEntityTypeConfiguration<UserPurchase>
    {
        public void Configure(EntityTypeBuilder<UserPurchase> builder)
        {
            builder.ToTable("UserPurchase");
            builder.HasKey(entity => new { entity.ComicId, entity.UserId });
            builder.Property(entity => entity.ComicId);
            builder.Property(entity => entity.Price);
            builder.Property(entity => entity.CreatedAt)
                    .HasColumnType("datetime");
            builder.HasOne(user => user.User)
                .WithMany(purchase => purchase.PurchasedItems)
                .HasForeignKey(entity => entity.ComicId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}