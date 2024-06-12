using Microsoft.EntityFrameworkCore;
using PojetoEmprestimoLivros.Data;
using PojetoEmprestimoLivros.Models;

namespace PojetoEmprestimoLivros.Services.LivroServices
{
    public class LivroServices : ILivroInterface
    {
        private readonly AppDbContext _context;
        public LivroServices(AppDbContext context)
        {
            _context = context;
        }

        // Implementação do medoto BucarLivros();
        public async Task<List<LivrosModel>> BuscarLivros()
        {
            try
            {
                // entrar no banco , pegar todos os itend da tabela e transformar em uma lista.
                var livros = await _context.Livros.ToListAsync();
                return livros;

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}
