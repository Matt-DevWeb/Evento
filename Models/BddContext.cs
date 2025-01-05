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
            optionsBuilder.UseMySql("server=localhost;user id=root;password=root;database=testunit");
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Events.AddRange(
                new Event
                {
                    Id = 1,
                    Name = "Soirée Halloween",
                    Description = "Soirée déguisée",
                    StartDate = new DateTime(2021, 10, 31),
                    EndDate = new DateTime(2021, 10, 31),
                    Price = 10,
                    NumberOfTickets = 100,
                    Photo = "halloween.jpg",
                    AssociationId = 1,
                    VenueId = 2
                },
                new Event
                {
                    Id = 2,
                    Name = "Concert de Rock",
                    Description = "Un concert de rock incroyable.",
                    StartDate = new DateTime(2023, 11, 1),
                    EndDate = new DateTime(2023, 11, 1),
                    Price = 50,
                    NumberOfTickets = 200,
                    Photo = "rock_concert.jpg",
                    AssociationId = 1,
                    VenueId = 3
                }
            );
            this.Associations.AddRange(
                new Association
                {
                    Id = 1,
                    Name = "Association des fêtes",
                    Description = "Organisation de soirées",
                    Siret = "12345678901234"
                },
                new Association
                {
                    Id = 2,
                    Name = "Association des concerts",
                    Description = "Organisation de concerts",
                    Siret = "12345678901235"
                }
            );
            this.SaveChanges();
        }
    }
    
}
