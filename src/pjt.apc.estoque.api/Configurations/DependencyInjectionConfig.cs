using pjt.apc.estoque.crosscutting;

namespace pjt.apc.estoque.api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            DependencyInjector.Register(services);
        }
    }
}
