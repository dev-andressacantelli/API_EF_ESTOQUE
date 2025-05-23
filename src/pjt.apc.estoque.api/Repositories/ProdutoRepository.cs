﻿using pjt.apc.estoque.api.Context;
using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.api.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext produtoContext;
        public ProdutoRepository(ProdutoContext produtoContext)
        {
            this.produtoContext = produtoContext;
        }

        public async Task<List<Produto>> GetAllProdutosAsync()
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

        public async Task<List<Produto>> GetProdutosMasculino()
        {
            try
            {
                var ret = produtoContext.Produto.Where(x => x.Genero == "Masculino").ToList();

                if (!ret.Any()) return null;

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Produto>> GetProdutosFeminino()
        {
            try
            {
                var ret = produtoContext.Produto.Where(x => x.Genero == "Feminino").ToList();

                if (!ret.Any()) return null;

                return ret;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            try
            {
                Produto produto = produtoContext.Produto.Where(x => x.ID == id).FirstOrDefault();

                if (produto == null)
                {
                    return null;
                }

                return produto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<object> GetProdutoByName(string nome)
        {
            try
            {
                var ret = produtoContext.Produto.Where(x => x.Nome == nome).ToList();

                if (!ret.Any()) return null;

                return ret;                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> InsertProdutoAsync(Produto produto)
        {
            try
            {
                if (produto != null)
                {
                    string response = string.Empty;
                    produtoContext.Produto.Add(produto);
                    var ret = await produtoContext.SaveChangesAsync();
                    if (ret >= 0)
                        return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }        

        public async Task<bool> UpdateProdutoAsync(Produto produto)
        {
            try
            {
                if (produto != null)
                {
                    produtoContext.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    var ret = await produtoContext.SaveChangesAsync();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProdutoAsync(int id)
        {
            try
            {
                Produto produto = produtoContext.Produto.Where(x => x.ID == id).FirstOrDefault();

                if (produto != null)
                {
                    produtoContext.Produto.Remove(produto);
                    var ret = await produtoContext.SaveChangesAsync();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}