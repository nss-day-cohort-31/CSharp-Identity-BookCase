using System;
using System.Collections.Generic;
using System.Text;
using BookCase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookCase.Data
{

    // NOTE: Inherit from the generic IdentityDbContext<> when you have a custom User class
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }

        // NOTE: Override the OnModelCreating() method to seed your database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // NOTE: DON'T FORGET THIS LINE
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            var author = new Author()
            {
                Id = 1,
                FirstName = "Stephen",
                LastName = "King",
                PenName = "Richard Bachman",
                Genre = "Horror"
            };
            modelBuilder.Entity<Author>().HasData(author);

            var book = new Book()
            {
                Id = 1,
                Isbn = "1234512345",
                Title = "It",
                AuthorId = author.Id,
                PublishDate = new DateTime(1988, 4, 1),
                OwnerId = user.Id
            };
            modelBuilder.Entity<Book>().HasData(book);
        }
    }
}
