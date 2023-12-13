using CRMManager.Domain.Aggregates.CustomerAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Feartures.Customers.Queries
{
    public record ListAllCustomersQuery : IRequest<List<Customer>>;
}
