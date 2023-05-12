using App.Domain.Core.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infrastructures.Data.Repositories._IocConfigs
{
    public static class ServiceCollectionExtensions
    {
        public static void Add_AppRepositories(this IServiceCollection services)
        {
            // Repository Services
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
        }
    }
}
