
using LibraryAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class LibraryDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Book> Books { get; set; } = null!;
        public LibraryDbContext(
            DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }
    }
}
