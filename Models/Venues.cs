namespace Evento.Models
{
    public class Venues
    {
        public static List<Venue> GetVenues()
        {
            List<Venue> venues = new List<Venue>
            {
                new Venue
                {
                    Id = 1,
                    Name = "Salle des fêtes",
                    Description = "Salle des fêtes de la ville de Paris",
                    Capacity = 1000,
                    StreetNumber = 1,
                    StreetName = "Rue de la République",
                    City = "Paris",
                    ZipCode = "75001",
                    Country = "France",
                    Photo = "salle_des_fetes.jpg"
                },
                new Venue
                {
                    Id = 2,
                    Name = "Stade de France",
                    Description = "Stade de France",
                    Capacity = 80000,
                    StreetNumber = 1,
                    StreetName = "Rue des Sports",
                    City = "Saint-Denis",
                    ZipCode = "93200",
                    Country = "France",
                    Photo = "stade_de_france.jpg"
                },
                new Venue
                {
                    Id = 3,
                    Name = "Zénith de Paris",
                    Description = "Zénith de Paris",
                    Capacity = 6000,
                    StreetNumber = 1,
                    StreetName = "Avenue Jean Jaurès",
                    City = "Paris",
                    ZipCode = "75019",
                    Country = "France",
                    Photo = "zenith_de_paris.jpg"
                },
                new Venue
                {
                    Id = 4,
                    Name = "Opéra Garnier",
                    Description = "Opéra historique de Paris",
                    Capacity = 1979,
                    StreetNumber = 8,
                    StreetName = "Rue Scribe",
                    City = "Paris",
                    ZipCode = "75009",
                    Country = "France",
                    Photo = "opera_garnier.jpg"
                },
                new Venue
                {
                    Id = 5,
                    Name = "Palais des Congrès",
                    Description = "Centre de congrès et de spectacles",
                    Capacity = 3723,
                    StreetNumber = 2,
                    StreetName = "Place de la Porte Maillot",
                    City = "Paris",
                    ZipCode = "75017",
                    Country = "France",
                    Photo = "palais_des_congres.jpg"
                },
                new Venue
                {
                    Id = 6,
                    Name = "Théâtre Mogador",
                    Description = "Théâtre de spectacles et comédies musicales",
                    Capacity = 1600,
                    StreetNumber = 25,
                    StreetName = "Rue de Mogador",
                    City = "Paris",
                    ZipCode = "75009",
                    Country = "France",
                    Photo = "theatre_mogador.jpg"
                },
                new Venue
                {
                    Id = 7,
                    Name = "Centre Pompidou",
                    Description = "Centre national d'art et de culture",
                    Capacity = 2000,
                    StreetNumber = 19,
                    StreetName = "Rue Beaubourg",
                    City = "Paris",
                    ZipCode = "75004",
                    Country = "France",
                    Photo = "centre_pompidou.jpg"
                },
                new Venue
                {
                    Id = 8,
                    Name = "Philharmonie de Paris",
                    Description = "Salle de concert symphonique",
                    Capacity = 2400,
                    StreetNumber = 221,
                    StreetName = "Avenue Jean Jaurès",
                    City = "Paris",
                    ZipCode = "75019",
                    Country = "France",
                    Photo = "philharmonie_de_paris.jpg"
                }
            };
            return venues;
        }
    }
}
