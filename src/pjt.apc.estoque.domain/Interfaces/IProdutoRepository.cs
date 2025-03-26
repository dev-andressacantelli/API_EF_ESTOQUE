using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.domain.Interfaces
{
    public interface IProdutoRepository
    {
        public Task<List<Produto>> GetAllProdutosOrderByIdAsync();
        public Task<List<Produto>> GetAllProdutosOrderByNameAsync();
        public Task<List<Produto>> GetProdutosOrderByGeneroMasculino();
        public Task<List<Produto>> GetProdutosOrderByGeneroFeminino();
        public Task<Produto> GetProdutoById(int id);
        public Task<Produto> GetProdutoByName(string nome);
        public Task<bool> InsertProdutoAsync(Produto produto);
        public Task<Produto> UpdateProdutoAsync(Produto produto);
        public Task<Produto> DeleteProdutoAsync(int id);
    }
}