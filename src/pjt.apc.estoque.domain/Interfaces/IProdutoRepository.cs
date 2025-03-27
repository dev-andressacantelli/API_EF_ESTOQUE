using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.domain.Interfaces
{
    public interface IProdutoRepository
    {
        public Task<List<Produto>> GetAllProdutosAsync();    
        public Task<List<Produto>> GetProdutosMasculino();
        public Task<List<Produto>> GetProdutosFeminino();
        public Task<Produto> GetProdutoById(int id);
        public Task<Produto> GetProdutoByName(string nome);
        public Task<bool> InsertProdutoAsync(Produto produto);
        public Task<bool> UpdateProdutoAsync(Produto produto);
        public Task<Produto> DeleteProdutoAsync(int id);
    }
}