using Microsoft.EntityFrameworkCore;

namespace Pierogarnia.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Issue> Issues { get; set; }

    }
}