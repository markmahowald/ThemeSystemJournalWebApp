using ThemeSystemJournalWebApp.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;


namespace ThemeSystemJournalWebApp.DataLayer.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<JournalEntry> JournalEntries { get; set; }

    }
}
