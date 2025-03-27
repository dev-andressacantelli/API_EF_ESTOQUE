using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.domain.Results;
using System.Runtime.InteropServices;

namespace pjt.apc.estoque.application.Dispatcher
{
    public class ProdutoDispatcher : IProdutoDispatcher
    {
        private IProdutoRepository _produtoRepository;
        public ProdutoDispatcher(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        Response result = new();

        public async Task<Response> GetAllProdutosAsync()
        {            
            try
            {
                var consultaDb = await _produtoRepository.GetAllProdutosAsync();

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }
                              
                result.Resultado.Mensagem = "Não foi possível retornar os produtos! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {               
                return result;
            }
        }        

        public async Task<Response> GetProdutosMasculino()
        {
            try
            {
                var consultaDb = await _produtoRepository.GetProdutosMasculino();

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                result.Resultado.Mensagem = "Não foi possível retornar os produtos! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        public async Task<Response> GetProdutosFeminino()
        {
            try
            {
                var consultaDb = await _produtoRepository.GetProdutosFeminino();

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                result.Resultado.Mensagem = "Não foi possível retornar os produtos! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        public async Task<Response> GetProdutoById(int id)
        {           
            try
            {
                var consultaDb = await _produtoRepository.GetProdutoById(id);

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }
                
                result.Resultado.Mensagem = "Não foi possível retornar os dados! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
              
                return result;
            }
        }

        public Task<Response> GetProdutoByName(string nome)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> InsertProdutoAsync(Produto produto)
        {
            if (produto != null)
            {
                try
                {
                    var addData = await _produtoRepository.InsertProdutoAsync(produto);

                    if (addData == true)
                    {
                        result.Resultado.Mensagem = "Produto adicionado com sucesso ao banco de dados!";
                    }                    
                }
                catch (Exception)
                {
                    result.Resultado.Mensagem = "Não foi possível adicionar o produto! Verifique se os campos estão devidamente preenchidos!";
                    return result;
                }
            }
           
            return result;
        }

        public Task<Response> UpdateProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteProdutoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}