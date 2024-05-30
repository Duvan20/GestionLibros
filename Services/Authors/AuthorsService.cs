using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Data;
using SimulacroGestionLibros.Models;
using Microsoft.EntityFrameworkCore;

namespace SimulacroGestionLibros.Services.Authors
{
    public class AuthorsService : IAuthorsService
    {
        private readonly GestionLibrosContext _context;

        public AuthorsService(GestionLibrosContext context)
        {
            _context = context;
        }

        public Author CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return author;

        }

        public Task<Author> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public async Task<Author> SearchAuthors(int Search)
        {
            return await _context.Authors.FindAsync(Search);
        }

        public Author UpdateAuthor(Author author,int id)
        {
            author.Id =id;
            _context.Authors.Update(author);
            _context.SaveChanges();
            return author;
        }
    }
}