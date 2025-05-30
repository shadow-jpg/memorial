﻿using Microsoft.AspNetCore.Identity;
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
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Author> Authors { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chapter>()
            .HasOne(c => c.Book)
            .WithMany(b => b.Chapters)
            .HasForeignKey(c => c.BookId)
            .OnDelete(DeleteBehavior.Cascade);

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

            modelBuilder.Entity<User>();

            modelBuilder.Entity<UserBook>()
                .HasKey(ub => new { ub.UserId, ub.BookId });

            modelBuilder.Entity<UserBook>()
                .HasOne(ub => ub.User)
                .WithMany(u => u.UserBooks)
                .HasForeignKey(ub => ub.UserId);

            modelBuilder.Entity<UserBook>()
                .HasOne(ub => ub.Book)
                .WithMany(b => b.UserBooks)
                .HasForeignKey(ub => ub.BookId);
        }
    }
}