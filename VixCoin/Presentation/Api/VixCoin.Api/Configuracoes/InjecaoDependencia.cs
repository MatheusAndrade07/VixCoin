using VixCoin.Application.Services;
using VixCoin.Core.Interfaces.Repositories;
using VixCoin.Core.Interfaces.Services;
using VixCoin.Infra.Data.Repositories;

namespace VixCoin.Api.Configuracoes
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolveDependencias
            (this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
