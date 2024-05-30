using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimulacroGestionLibros.Models;
using Microsoft.Extensions.Logging;
using SimulacroGestionLibros.Services.Editorials;

namespace SimulacroGestionLibros.Controllers.Editorials
{
    [Route("[controller]")]
    [ApiController]
    public class SearchEditorialController : Controller
    {
        private readonly IEditorialsService _EditorialService;

        public SearchEditorialController(IEditorialsService EditorialService)
        {
            _EditorialService = EditorialService;
        }

        [HttpGet("{search?}")]
        public async Task<ActionResult<Editorial>> Search(int search)
        {
            var result =await  _EditorialService.Search(search);
            return Ok(result);
        }



      
    }
}