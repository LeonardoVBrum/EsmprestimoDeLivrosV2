using PojetoEmprestimoLivros.Models;

namespace PojetoEmprestimoLivros.Services.LivroServices
{
    public interface ILivroInterface
    {
        //Validação do metodo  BuscarLivros();
        Task<List<LivrosModel>> BuscarLivros();

    }
}
