using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.domain.Results;

namespace pjt.apc.estoque.domain.Interfaces
{
    public interface IProdutoDispatcher
    {
        public Task<Response> GetAllProdutosOrderByIdAsync();
        public Task<Response> GetAllProdutosOrderByNameAsync();
        public Task<Response> GetProdutosOrderByGeneroMasculino();
        public Task<Response> GetProdutosOrderByGeneroFeminino();
        public Task<Response> GetProdutoById(int id);
        public Task<Response> GetProdutoByName(string nome);
        public Task<Response> InsertProdutoAsync(Produto produto);
        public Task<Response> UpdateProdutoAsync(Produto produto);
        public Task<Response> DeleteProdutoAsync(int id);
    }
}

/*
● Criar um produto 
○ O valor do produto não pode ser negativo 
● Atualizar um produto 
● Deletar um produto 
● Listar os produtos 
○ Ordenar os produtos por diferentes campos 
○ Buscar produto pelo nome 
● Consultar um produto específico 
○ Buscar produto pelo identificador 
○ Buscar produto pelo nome 
 */