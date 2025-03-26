using Microsoft.EntityFrameworkCore;
using pjt.apc.estoque.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt.apc.estoque.domain.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}