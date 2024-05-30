using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using Microsoft.Extensions.Logging;
using SimulacroGestionLibros.Services.Books;


namespace SimulacroGestionLibros.Controllers.Books
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public  ActionResult<Book> GerAuthors()
        {
            var result = _booksService.GetBooks();

            var loquequieromostrar = result.Select(b => new 
            {
                b.Id,
                b.Title,
                b.Description,
                b.PublicationDate,
                Author = b.author != null ? b.author.Name : null,
                Editorial = b.editorial != null ? b.editorial.Name : null,b.editorial.Phone
             
            });
            return Ok(loquequieromostrar);         
        }     
      
    }
}