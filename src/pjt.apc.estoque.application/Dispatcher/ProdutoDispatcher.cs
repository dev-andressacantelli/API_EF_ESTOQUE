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


        public async Task<Response> GetAllProdutosOrderByIdAsync()
        {
            Response result = new();

            try
            {
                var consultaDb = await _produtoRepository.GetAllProdutosOrderByIdAsync();

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                //result.StatusCode = StatusCodes.Status404NotFound;
                result.Resultado.Mensagem = "Não foi possível retornar os dados! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
                //result.StatusCode = StatusCodes.Status500InternalServerError;
                return result;
            }
        }

        public async Task<Response> GetAllProdutosOrderByNameAsync()
        {
            Response result = new();

            try
            {
                var consultaDb = await _produtoRepository.GetAllProdutosOrderByNameAsync();

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                //result.StatusCode = StatusCodes.Status404NotFound;
                result.Resultado.Mensagem = "Não foi possível retornar os dados! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
                //result.StatusCode = StatusCodes.Status500InternalServerError;
                return result;
            }
        }

        public Task<Response> GetProdutosOrderByGeneroMasculino()
        {
            throw new NotImplementedException();
        }

        public Task<Response> GetProdutosOrderByGeneroFeminino()
        {
            throw new NotImplementedException();
        }

        public async Task<Response> GetProdutoById(int id)
        {
            Response result = new();

            try
            {
                var consultaDb = await _produtoRepository.GetProdutoById(id);

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                //result.StatusCode = StatusCodes.Status404NotFound;
                result.Resultado.Mensagem = "Não foi possível retornar os dados! Verifique a conexão com o banco de dados.";
                return result;
            }
            catch (Exception)
            {
                //result.StatusCode = StatusCodes.Status500InternalServerError;
                return result;
            }
        }

        public Task<Response> GetProdutoByName(string nome)
        {
            throw new NotImplementedException();
        }  

        public Task<Response> InsertProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
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