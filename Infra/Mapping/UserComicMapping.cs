using ComicStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicStoreApi.Infra.Mapping
{
    public class UserComicMapping : IEntityTypeConfiguration<UserComic>
    {
        public void Configure(EntityTypeBuilder<UserComic> builder)
        {
            builder.ToTable("UserComic");
            builder.HasKey(entity => new { entity.ComicId, entity.UserId });
            builder.Property(entity => entity.ComicId);   
            builder.HasOne(user => user.User)
                .WithMany(comics => comics.UsersComics)
                .HasForeignKey(entity => entity.ComicId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}