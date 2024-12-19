namespace Evento.Models
{
    public class Events
    {
        public static List<Event> GetEvents()
        {
            return new List<Event>()
                        {
                            new Event { Id = 1, Name = "Concert de Rock", Description = "Un concert de rock incroyable.", StartDate = new DateTime(2023, 11, 1), EndDate = new DateTime(2023, 11, 1), Price = 50.0f, NumberOfTickets = 200, NumberOfTicketsSold = 150, Photo = "rock_concert.jpg", AssociationId = 1, VenueId = 1 },
                            new Event { Id = 2, Name = "Festival de Jazz", Description = "Un festival de jazz relaxant.", StartDate = new DateTime(2023, 12, 5), EndDate = new DateTime(2023, 12, 7), Price = 75.0f, NumberOfTickets = 300, NumberOfTicketsSold = 250, Photo = "jazz_festival.jpg", AssociationId = 2, VenueId = 2 },
                            new Event { Id = 3, Name = "Conférence Tech", Description = "Une conférence sur les nouvelles technologies.", StartDate = new DateTime(2024, 1, 15), EndDate = new DateTime(2024, 1, 16), Price = 100.0f, NumberOfTickets = 500, NumberOfTicketsSold = 450, Photo = "tech_conference.jpg", AssociationId = 3, VenueId = 3 },
                            new Event { Id = 4, Name = "Salon du Livre", Description = "Un salon pour les amateurs de livres.", StartDate = new DateTime(2024, 2, 20), EndDate = new DateTime(2024, 2, 22), Price = 20.0f, NumberOfTickets = 1000, NumberOfTicketsSold = 800, Photo = "book_fair.jpg", AssociationId = 4, VenueId = 4 },
                            new Event { Id = 5, Name = "Exposition d'Art", Description = "Une exposition d'art moderne.", StartDate = new DateTime(2024, 3, 10), EndDate = new DateTime(2024, 3, 15), Price = 30.0f, NumberOfTickets = 400, NumberOfTicketsSold = 350, Photo = "art_exhibition.jpg", AssociationId = 5, VenueId = 5 },
                            new Event { Id = 6, Name = "Marathon", Description = "Un marathon pour les sportifs.", StartDate = new DateTime(2024, 4, 5), EndDate = new DateTime(2024, 4, 5), Price = 25.0f, NumberOfTickets = 2000, NumberOfTicketsSold = 1800, Photo = "marathon.jpg", AssociationId = 1, VenueId = 6 },
                            new Event { Id = 7, Name = "Pièce de Théâtre", Description = "Une pièce de théâtre classique.", StartDate = new DateTime(2024, 5, 12), EndDate = new DateTime(2024, 5, 12), Price = 40.0f, NumberOfTickets = 300, NumberOfTicketsSold = 250, Photo = "theater_play.jpg", AssociationId = 2, VenueId = 7 },
                            new Event { Id = 8, Name = "Compétition d'E-sport", Description = "Une compétition de jeux vidéo.", StartDate = new DateTime(2024, 6, 18), EndDate = new DateTime(2024, 6, 20), Price = 60.0f, NumberOfTickets = 600, NumberOfTicketsSold = 550, Photo = "esport_competition.jpg", AssociationId = 3, VenueId = 8 },
                            new Event { Id = 9, Name = "Cours de Cuisine", Description = "Un cours de cuisine pour les amateurs.", StartDate = new DateTime(2024, 7, 25), EndDate = new DateTime(2024, 7, 25), Price = 80.0f, NumberOfTickets = 50, NumberOfTicketsSold = 45, Photo = "cooking_class.jpg", AssociationId = 4, VenueId = 1 },
                            new Event { Id = 10, Name = "Projection de Film", Description = "Une projection de film en plein air.", StartDate = new DateTime(2024, 8, 30), EndDate = new DateTime(2024, 8, 30), Price = 15.0f, NumberOfTickets = 500, NumberOfTicketsSold = 450, Photo = "movie_screening.jpg", AssociationId = 5, VenueId = 2 },
                            new Event { Id = 11, Name = "Gala de Charité", Description = "Un gala de charité pour une bonne cause.", StartDate = new DateTime(2024, 12, 20), EndDate = new DateTime(2024, 12, 20), Price = 150.0f, NumberOfTickets = 200, NumberOfTicketsSold = 180, Photo = "charity_gala.jpg", AssociationId = 1, VenueId = 3 },
                            new Event { Id = 12, Name = "Conférence sur l'IA", Description = "Une conférence sur l'intelligence artificielle.", StartDate = new DateTime(2025, 1, 10), EndDate = new DateTime(2025, 1, 12), Price = 200.0f, NumberOfTickets = 300, NumberOfTicketsSold = 250, Photo = "ai_conference.jpg", AssociationId = 2, VenueId = 4 },
                            new Event { Id = 13, Name = "Festival de Musique Électronique", Description = "Un festival de musique électronique.", StartDate = new DateTime(2025, 2, 15), EndDate = new DateTime(2025, 2, 17), Price = 100.0f, NumberOfTickets = 500, NumberOfTicketsSold = 450, Photo = "electronic_music_festival.jpg", AssociationId = 3, VenueId = 5 }
                        };
        }
    }
}
