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

        public async Task<Response> InsertProdutoAsync(Produto produto)
        {
            //Response result = new();

            if (produto != null)
            {
                try
                {
                    var addData = await _produtoRepository.InsertProdutoAsync(produto);

                    if (addData == true)
                    {
                        result.Resultado.Mensagem = "Produto adicionado com sucesso ao banco de dados!";
                    }

                    //result.Resultado.Mensagem = "Não foi possível adicionar o produto! Verifique a conexão com o banco de dados.";
                    //return result;
                }
                catch (Exception)
                {
                    result.Resultado.Mensagem = "Não foi possível adicionar o produto! Verifique se os campos estão devidamente preenchidos!";
                    return result;
                }
            }

            //result.Resultado.Mensagem = "Não é possível adicionar um produto com valor nulo!";
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