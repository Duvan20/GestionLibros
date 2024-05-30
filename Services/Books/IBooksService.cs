using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Models;

namespace SimulacroGestionLibros.Services.Books
{
    public interface IBooksService
    {
        //get books
        IEnumerable<Book> GetBooks();

        //buscardor 
        Task <Book> SearchBook(int Search);

        //update
        Book UpdateBook(Book book,int id);

        //create
        Book CrearBook(Book book);

        //delete o actualizar estado a eliminado y guardar en poll
        Task <Book> DELETE(string id);





    }
}