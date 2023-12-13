using CRMManager.Domain.Aggregates.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Infrastructure.Persistence
{
    public class CRMManagerContext:DbContext
    {
        public CRMManagerContext(DbContextOptions<CRMManagerContext> options) : base(options)
        {
            
        }
        public DbSet<Customer> customers { get; set; }
    }
}
