using Microsoft.EntityFrameworkCore;

namespace Evento.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Association> Associations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=26091993;database=Evento");
        }
    }
    
}
