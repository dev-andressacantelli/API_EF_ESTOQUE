using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.domain.Results;

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
               
                result.Resultado.Mensagem = "Não existe produto cadastrado com esse ID, ou o mesmo foi deletado da base de banco de dados.";
                return result;
            }
            catch (Exception)
            {
              
                return result;
            }
        }

        public async Task<Response> GetProdutoByName(string nome)
        {
            try
            {
                var consultaDb = await _produtoRepository.GetProdutoByName(nome);

                if (consultaDb != null)
                {
                    result.Resultado.Objeto = consultaDb;
                    return result;
                }

                result.Resultado.Mensagem = "Não existe produto cadastrado com esse Nome, ou o mesmo foi deletado da base de banco de dados.";
                return result;
            }
            catch (Exception)
            {

                return result;
            }
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

        public async Task<Response> UpdateProdutoAsync(Produto produto)
        {
            if (produto != null)
            {
                try
                {
                    var alterData = await _produtoRepository.UpdateProdutoAsync(produto);

                    if (alterData == true)
                    {
                        result.Resultado.Mensagem = "Produto alterado com sucesso no banco de dados!";
                    }

                    result.Resultado.Mensagem = "Não foi possível alterar o produto! Verifique se os campos estão devidamente preenchidos!";
                    return result;
                }
                catch (Exception)
                {
                    result.Resultado.Mensagem = "Não foi possível alterar o produto! Verifique se os campos estão devidamente preenchidos!";
                    return result;
                }
            }

            return result;
        }

        public async Task<Response> DeleteProdutoAsync(int id)
        {

            if (id != 0)
            {
                try
                {
                    var alterData = await _produtoRepository.DeleteProdutoAsync(id);

                    if (alterData == true)
                    {
                        result.Resultado.Mensagem = "Produto deletado da base de dados com sucesso!";
                    }

                    result.Resultado.Mensagem = "Não foi possível deletar o produto! Verifique se há produto cadastrado com esse ID.";
                    return result;
                }
                catch (Exception)
                {
                    result.Resultado.Mensagem = "Não foi possível deletar o produto! Verifique se há produto cadastrado com esse ID.";
                    return result;
                }
            }

            return result;
        }
    }
}