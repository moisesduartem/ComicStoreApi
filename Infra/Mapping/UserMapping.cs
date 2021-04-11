using ComicStoreApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicStoreApi.Infra.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Name);
            builder.HasIndex(entity => entity.Username).IsUnique();
            builder.HasIndex(entity => entity.Email).IsUnique();
            builder.Property(entity => entity.Password);
            builder.HasMany(user => user.PurchasedItems)
                   .WithOne(comic => comic.User)
                   .HasForeignKey(entity => entity.UserId);
        }
    }
}