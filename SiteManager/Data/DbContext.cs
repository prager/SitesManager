using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppAuthSQLite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }

    public class Note
    {
        public int Id { get; set; }  // ✅ This is treated as the primary key by convention

        public string Title { get; set; }
        public string Content { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
