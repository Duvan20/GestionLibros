using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using SimulacroGestionLibros.Services.Authors;
using Microsoft.Extensions.Logging;

namespace SimulacroGestionLibros.Controllers
{
    [Route("Authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _AuthorsService;

        public AuthorsController(IAuthorsService AuthorsService)
        {
            _AuthorsService = AuthorsService;
        }

        [HttpGet]
        public  ActionResult<Author> GerAuthors()
        {
           
            var result =_AuthorsService.GetAuthors(); 
            Console.WriteLine(result);
            return Ok(result);
        
          
        }      
    }
}