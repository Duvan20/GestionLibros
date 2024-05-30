
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
namespace SimulacroGestionLibros.Models
{
    public class Author
    {
        public int Id {get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        [StringLength(50, ErrorMessage = "el Name no puede ser mayor a 50 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Nationality { get; set; }

        public string? Status { get; set; }

        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }
 
    }
} 