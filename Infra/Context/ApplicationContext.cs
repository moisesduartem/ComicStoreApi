using ComicStoreApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComicStoreApi.Infra.Context
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=superuser;Persist Security Info=True;User ID=sa;Initial Catalog=ComicStoreApi;Data Source=LAPTOP-R6D0M2P1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserComic>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ComicId });
            });
        }
    }
}