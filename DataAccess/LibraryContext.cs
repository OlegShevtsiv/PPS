using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess
{
    public class LibraryContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
       // public DbSet<User> Users { get; set; }
        public DbSet<BookStorage> BookStorages { get; set; }


        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
