namespace Evento.Models
{
    

    public static class Associations
    {
        public static List<Association> GetAssociations()
        {
            return new List<Association>()
            { 
                   new Association { Id = 1, Name = "Festival de Musique", Description = "Organisation du festival annuel de musique", Siret = "12345678900011" },
                   new Association { Id = 2, Name = "Marathon de la Ville", Description = "Organisation du marathon annuel de la ville", Siret = "12345678900022" },
                   new Association { Id = 3, Name = "Salon du Livre", Description = "Organisation du salon du livre", Siret = "12345678900033" },
                   new Association { Id = 4, Name = "Exposition d'Art", Description = "Organisation de l'exposition d'art contemporain", Siret = "12345678900044" },
                   new Association { Id = 5, Name = "Conférence Tech", Description = "Organisation de la conférence annuelle sur les nouvelles technologies", Siret = "12345678900055" }
             };
        }
    }
}
