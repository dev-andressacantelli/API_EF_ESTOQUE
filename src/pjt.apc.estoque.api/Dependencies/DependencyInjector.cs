using Microsoft.Extensions.DependencyInjection;
using pjt.apc.estoque.api.Repositories;
using pjt.apc.estoque.application.Dispatcher;
using pjt.apc.estoque.domain.Interfaces;

namespace pjt.apc.estoque.api.Dependencies
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {      
            svcCollection.AddScoped<IProdutoDispatcher, ProdutoDispatcher>();
            svcCollection.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}