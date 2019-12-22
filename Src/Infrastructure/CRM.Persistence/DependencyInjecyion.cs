using CRM.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.Persistence
{
    public static class DependencyInjecyion
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CRMDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("defaultConnection")));

            services.AddScoped<IdbContext>(provider => provider.GetService<CRMDbContext>());

            return services;
        }
    }
}
