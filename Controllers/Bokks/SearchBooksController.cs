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
    public class SearchBooksController : Controller
    {
        private readonly IBooksService _booksService;

        public SearchBooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("{search?}")]
        public async Task<ActionResult<Book>> Get(int search)
        {
            var result =await  _booksService.SearchBook(search);
            return Ok(result);
        }

    }
}