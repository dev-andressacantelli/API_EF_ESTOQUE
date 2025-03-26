using Microsoft.Extensions.DependencyInjection;
using pjt.apc.estoque.application.Dispatcher;
using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt.apc.estoque.crosscutting
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {
            /* EXEMPLO
            // Application
            svcCollection.AddScoped(typeof(IAppServiceBase<,>), typeof(AppServiceBase<,>));
            svcCollection.AddScoped<IDishAppService, DishAppService>();

            // Domain
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IDishService, DishService>();

            // Infra.Data
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IDishRepository, DishRepository>(); */

            svcCollection.AddScoped<IProdutoDispatcher, ProdutoDispatcher>();
            svcCollection.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
