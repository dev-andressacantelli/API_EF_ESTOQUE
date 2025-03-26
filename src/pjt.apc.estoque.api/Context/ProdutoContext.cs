using Microsoft.EntityFrameworkCore;
using pjt.apc.estoque.domain.Models;

namespace pjt.apc.estoque.api.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}