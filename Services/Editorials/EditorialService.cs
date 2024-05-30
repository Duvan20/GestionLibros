using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Models;
using SimulacroGestionLibros.Data;

namespace SimulacroGestionLibros.Services.Editorials
{
    public class EditorialService : IEditorialsService
    {
        private readonly GestionLibrosContext _context;

        public EditorialService(GestionLibrosContext context)
        {
            _context = context;
        }

        public Editorial CreateEditorial(Editorial editorial)
        {
            _context.Editorials.Add(editorial);
            _context.SaveChanges();
            return editorial;
        }

        public IEnumerable<Editorial> GetEditorials()
        {
            return _context.Editorials.ToList();
        }

        public async Task<Editorial> Search(int Search)
        {
            return await _context.Editorials.FindAsync(Search);
        }

        public Editorial UpdateEditorial(Editorial editorial, int id)
        {
            editorial.Id = id;
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
            return editorial;
        }
    }
}