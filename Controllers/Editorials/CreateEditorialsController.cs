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
    public class CreateEditorialsController : Controller
    {
         private readonly IEditorialsService _EditorialService;

        public CreateEditorialsController(IEditorialsService EditorialService)
        {
            _EditorialService = EditorialService;
        }

        public Editorial CreateEditorial(Editorial editorial)
        {
            var result = _EditorialService.CreateEditorial(editorial);
            return result;

        }

       
    }
}