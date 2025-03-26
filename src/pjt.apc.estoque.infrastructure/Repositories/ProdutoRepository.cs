﻿using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;
using pjt.apc.estoque.infrastructure.Contexts;


namespace pjt.apc.estoque.infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Context produtoContext;
        public ProdutoRepository(Context produtoContext)
        {
            this.produtoContext = produtoContext;
        }


        /*
        public GerenteRepository(IDataAccess dataAccess) 
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Gerente>> GetAllGerentes()
        {
            throw new NotImplementedException();

            try
            {
                string sSQL = "";
                sSQL = @"SELECT * FROM tb_gerente ORDER BY SEQ_REGIONAL";

                var ret = await _dataAccess.QueryAsync<Gerente>(sql: sSQL);
                if (!ret.Any()) return null;

                return ret.ToList();
            }
            catch (Exception ex) 
            {
                return null;
            }      
        }
        */



        /*
    [HttpGet]
    [Route("GetUsers")]
    public List<Users> GetUsers()
    {
        return userContext.Users.ToList();
    }*/


        public async Task<List<Produto>> GetAllProdutosOrderByIdAsync()
        {
            try
            {
                var ret = produtoContext.Produto.ToList();               

                if (!ret.Any()) return null;

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
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


        /*
             [HttpGet]
        [Route("GetUser")]
        public Users GetUser(int id)
        {
            return userContext.Users.Where(x => x.ID == id).FirstOrDefault();
        }
         */
        /*
         [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(int id)
        {
            Users user = userContext.Users.Where(x => x.ID == id).FirstOrDefault();
            if (user != null)
            {
                userContext.Users.Remove(user);
                userContext.SaveChanges();
                return "User deleted";
            }
            else
            {
                return "No user found";
            }
        }
         
         */
        public Task<Produto> GetProdutoById(int id)
        {
            try
            {
               Produto produto = produtoContext.Produto.Where(x => x.ID == id).FirstOrDefault();                           

                if (produto == null)
                {
                    return null;
                }

                return null;              
            }
            catch (Exception ex)
            {
                return null;
            }
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