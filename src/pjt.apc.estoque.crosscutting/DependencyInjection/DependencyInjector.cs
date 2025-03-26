﻿using Microsoft.Extensions.DependencyInjection;
using pjt.apc.estoque.application.Dispatcher;
using pjt.apc.estoque.domain.Interfaces;
using pjt.apc.estoque.infrastructure.Repositories;


namespace pjt.apc.estoque.crosscutting.DependencyInjection
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection services)
        {
            /*
            // Application
            svcCollection.AddScoped(typeof(IAppServiceBase<,>), typeof(AppServiceBase<,>));
            svcCollection.AddScoped<IDishAppService, DishAppService>();

            // Domain
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IDishService, DishService>();

            // Infra.Data
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IDishRepository, DishRepository>(); */


            services.AddSingleton<IProdutoDispatcher, ProdutoDispatcher>();
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();      
        }
    }
}