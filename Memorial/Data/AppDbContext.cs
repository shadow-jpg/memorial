using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Memorial.Models;

namespace Memorial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Poem> Poems { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Poem>()
                .HasOne(p => p.Author)
                .WithMany(a => a.Poems)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Book>(entity =>
            {
                modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasMaxLength(50);
            });
        }
    }
}