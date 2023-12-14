using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Respositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CRMManagerContext>(options => options.UseSqlServer("Data Source=Lammoi;Initial Catalog=CRMManager;User ID=sa;Password=1;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
