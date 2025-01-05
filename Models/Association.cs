using System.ComponentModel.DataAnnotations;

namespace Evento.Models
{
    public class Association
    {
        public int Id { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Siret { get; set; }
    }
}
