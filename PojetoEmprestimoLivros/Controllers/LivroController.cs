using Microsoft.AspNetCore.Mvc;
using PojetoEmprestimoLivros.Services.LivroServices;

namespace PojetoEmprestimoLivros.Controllers
{
    public class LivroController : Controller
    {
        public LivroController(ILivroInterface livroInterface)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
