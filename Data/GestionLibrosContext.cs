using Microsoft.EntityFrameworkCore;
using SimulacroGestionLibros.Models;

namespace SimulacroGestionLibros.Data
{
    public class GestionLibrosContext : DbContext
    {
        public GestionLibrosContext (DbContextOptions<GestionLibrosContext> options): base(options)
        {
        }


        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Editorial> Editorials{ get; set; }
        
    }

}