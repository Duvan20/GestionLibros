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
    public class CreateAuthorsController
    {
        private readonly IAuthorsService _AuthorsService;

        public CreateAuthorsController(IAuthorsService AuthorsService)
        {
            _AuthorsService = AuthorsService;
        }

        [HttpPost]
        public Author Create(Author author)
        {
            var result = _AuthorsService.CreateAuthor(author);
            return result;
        }
        
        
    }
}