using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using Microsoft.Extensions.Logging;
using SimulacroGestionLibros.Services.Books;

namespace SimulacroGestionLibros.Controllers.Bokks
{
    [Route("[controller]")]
    [ApiController]
    public class CreateBooksController : Controller
    {
        private readonly IBooksService _booksService;

        public CreateBooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost]
        public Book CreateBooks(Book book)
        {
            var result = _booksService.CrearBook(book);
            return result;
        }


    }
}