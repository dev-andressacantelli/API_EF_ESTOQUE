using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        /*
        public ProdutoRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }     


        public async Task<List<Produto>> GetAllProdutosOrderByIdAsync()
        {
            try
            {
                string sSQL = "";
                sSQL = @"SELECT * FROM tb_produto ORDER BY ID";

                var ret = await _dataAccess.QueryAsync<Produto>(sql: sSQL);
                if (!ret.Any()) return null;

                return ret.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Produto>> GetAllProdutosOrderByNameAsync()
        {
            try
            {
                string sSQL = "";
                sSQL = @"SELECT * FROM tb_produto ORDER BY NOME";

                var ret = await _dataAccess.QueryAsync<Produto>(sql: sSQL);
                if (!ret.Any()) return null;

                return ret.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Produto>> GetProdutosOrderByGeneroMasculino()
        {
            try
            {
                string sSQL = "";
                sSQL = @"SELECT * FROM tb_produto ORDER BY GENERO_M";

                var ret = await _dataAccess.QueryAsync<Produto>(sql: sSQL);
                if (!ret.Any()) return null;

                return ret.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Produto>> GetProdutosOrderByGeneroFeminino()
        {
            try
            {
                string sSQL = "";
                sSQL = @"SELECT * FROM tb_produto ORDER BY GENERO_F";

                var ret = await _dataAccess.QueryAsync<Produto>(sql: sSQL);
                if (!ret.Any()) return null;

                return ret.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
        */

        public Task<List<Produto>> GetAllProdutosOrderByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetAllProdutosOrderByNameAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetProdutosOrderByGeneroMasculino()
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetProdutosOrderByGeneroFeminino()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetProdutoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetProdutoByName(string nome)
        {
            throw new NotImplementedException();
        } 

        public Task<Produto> InsertProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> UpdateProdutoAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> DeleteProdutoAsync(int id)
        {
            throw new NotImplementedException();
        }      
    }
}