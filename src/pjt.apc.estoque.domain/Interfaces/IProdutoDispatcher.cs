using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.domain.Results;

namespace pjt.apc.estoque.domain.Interfaces
{
    public interface IProdutoDispatcher
    {
        public Task<Response> GetAllProdutosAsync();      
        public Task<Response> GetProdutosMasculino();
        public Task<Response> GetProdutosFeminino();
        public Task<Response> GetProdutoById(int id);
        public Task<Response> GetProdutoByName(string nome);
        public Task<Response> InsertProdutoAsync(Produto produto);
        public Task<Response> UpdateProdutoAsync(Produto produto);
        public Task<Response> DeleteProdutoAsync(int id);
    }
}