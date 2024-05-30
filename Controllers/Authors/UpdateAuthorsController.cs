using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using SimulacroGestionLibros.Services.Authors;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SimulacroGestionLibros.Controllers.Authors
{
    [Route("[controller]")]
    [ApiController]
    public class UpdateAuthorsController : Controller
    {
        private readonly IAuthorsService _AuthorsService;

        public UpdateAuthorsController(IAuthorsService AuthorsService)
        {
            _AuthorsService = AuthorsService;
        }

        [HttpPut]
        public Author UpdateAuthors(Author author)
        {
            var result =  _AuthorsService.UpdateAuthor(author,author.Id);
            return result;
        }

       
    }
}