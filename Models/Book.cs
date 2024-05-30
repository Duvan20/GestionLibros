using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace SimulacroGestionLibros.Models
{
    public class Book
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]

        public  string? Language { get; set; }

        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]

        public DateTime PublicationDate { get; set; }


        [Required(ErrorMessage = "El campo CategoryName es Obligatorio")]
        public string? Description { get; set; }

        public string? Status { get; set; }

        public int Authorid { get; set;}
        public Author? author { get; set;}

        public int Editorialid { get; set;}

        public Editorial? editorial { get; set;} 

    }
}