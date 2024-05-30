using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace SimulacroGestionLibros.Models
{
    public class Editorial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Name{ get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string?  Email{get; set; }

        public string? Status { get; set; }

        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }

        
    }
}