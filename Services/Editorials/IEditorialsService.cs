using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Models;

namespace SimulacroGestionLibros.Services.Editorials
{
    public interface IEditorialsService
    {

        IEnumerable<Editorial> GetEditorials();

        Editorial CreateEditorial(Editorial editorial);


        Editorial UpdateEditorial(Editorial editorial,int id);

        Task<Editorial> Search(int Search);
        
    }
}