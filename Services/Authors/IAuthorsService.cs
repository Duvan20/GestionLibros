using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulacroGestionLibros.Models;


namespace SimulacroGestionLibros.Services.Authors
{
    public interface IAuthorsService
    {
        //get Authors
        IEnumerable<Author> GetAuthors(); 

        //Buscador 
        Task<Author> SearchAuthors(int Search);

        //Crear authors
        Author CreateAuthor(Author author);

        //update Author
        Author UpdateAuthor(Author author,int id);



        //delete o actualizacion de estado y guardar en poll
        Task<Author> Delete(string id); 





    }
}