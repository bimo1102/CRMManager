using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Respositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CRMManagerContext>(options => options.UseSqlServer("Data Source=Lammoi\\SQLEXPRESS;Initial Catalog=CRMManager;User ID=sa;Password=1;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
