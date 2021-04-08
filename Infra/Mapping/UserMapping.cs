using ComicStoreApi.Models;
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
            builder.Property(entity => entity.Nome);
            builder.Property(entity => entity.Username);
            builder.Property(entity => entity.Email);
            builder.Property(entity => entity.Password);
            builder.HasMany(user => user.UsersComics)
                   .WithOne(comic => comic.User)
                   .HasForeignKey(entity => entity.UserId);
        }
    }
}