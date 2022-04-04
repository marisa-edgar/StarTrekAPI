using Microsoft.EntityFrameworkCore;

namespace StarTrek.Models
{
    public class StarTrekContext : DbContext
    {
        public StarTrekContext(DbContextOptions<StarTrekContext> options)
            : base(options)
        {
        }

        public DbSet<TrekEvent> TrekEvents { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}