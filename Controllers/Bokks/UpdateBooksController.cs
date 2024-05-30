using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using SimulacroGestionLibros.Services.Books;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SimulacroGestionLibros.Controllers.Bokks
{
    [Route("[controller]")]
    [ApiController]
    public class UpdateBooksController : Controller
    {
        private readonly IBooksService _booksService;

        public UpdateBooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public Book UpdateBook(Book book)
        {
            var result = _booksService.UpdateBook(book,book.Id);
            return result;
        }
        
    }
}