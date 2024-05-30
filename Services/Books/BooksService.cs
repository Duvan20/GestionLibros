using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Models;
using SimulacroGestionLibros.Data;
using Microsoft.EntityFrameworkCore;

namespace SimulacroGestionLibros.Services.Books
{
    public class BooksService : IBooksService
    {

        private readonly GestionLibrosContext _context;

        public BooksService(GestionLibrosContext context)
        {
            _context = context;
        }

        public Book CrearBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Task<Book> DELETE(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.Include(b => b.author).Include(e => e.editorial).ToList();
        }

         public async Task<Book> SearchBook(int Search)
        {
            return await _context.Books.FindAsync(Search);
        }

        public Book UpdateBook(Book book, int id)
        {
            book.Id = id;
            _context.Books.Update(book);
            _context.SaveChanges();
            return book;
 
        }
    }
}