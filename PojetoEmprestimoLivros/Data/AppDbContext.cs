using Microsoft.EntityFrameworkCore;
using PojetoEmprestimoLivros.Models;

namespace PojetoEmprestimoLivros.Data
{
    public class AppDbContext : DbContext
    {
        // criando nosso construtor 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<LivrosModel> Livros {get; set;}
        
    }
}
