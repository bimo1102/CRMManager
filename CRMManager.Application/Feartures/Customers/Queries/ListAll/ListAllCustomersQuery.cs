using CRMManager.Application.Feartures.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using MediatR;

namespace CRMManager.Application.Feartures.Customers.Queries.ListAll
{
    public record ListAllCustomersQuery : IRequest<List<CustomerDto>>;
}
