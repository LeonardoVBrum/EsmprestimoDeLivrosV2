using Microsoft.AspNetCore.Mvc;
using PojetoEmprestimoLivros.Models;
using PojetoEmprestimoLivros.Services.LivroServices;

namespace PojetoEmprestimoLivros.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroInterface _livroInterface;
        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }
        public async Task<ActionResult<List<LivrosModel>>> Index()
        {
            //solicita os dados para o metodo da interface.
            var livros = await _livroInterface.BuscarLivros();
            return View(livros);
        }
    }
}
