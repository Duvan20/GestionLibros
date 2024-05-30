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
    public class EditorialsController : Controller
    {
        private readonly IEditorialsService _EditorialService;

        public EditorialsController(IEditorialsService EditorialService)
        {
            _EditorialService = EditorialService;
        }

        [HttpGet]
        public ActionResult<Editorial> GetEditorials()
        {
            var result = _EditorialService.GetEditorials();
            return Ok(result);
        }
       
    }
}