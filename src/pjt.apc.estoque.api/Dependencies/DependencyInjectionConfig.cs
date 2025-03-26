using Microsoft.Extensions.DependencyInjection;

namespace pjt.apc.estoque.api.Dependencies
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            DependencyInjector.Register(services);
        }
    }
}