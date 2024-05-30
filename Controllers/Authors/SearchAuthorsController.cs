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
    public class SearchAuthorsController : Controller
    {
        private readonly IAuthorsService _AuthorsService;

        public SearchAuthorsController(IAuthorsService AuthorsService)
        {
            _AuthorsService = AuthorsService;
        }
        
        [HttpGet("{search?}")]
        public async Task<ActionResult<Author>> Get(int search)
        {
            var result =await  _AuthorsService.SearchAuthors(search);
            return Ok(result);
        }
        

    }
      
}