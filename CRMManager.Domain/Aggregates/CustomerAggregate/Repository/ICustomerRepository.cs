using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Interfaces;

namespace CRMManager.Domain.Aggregates.CustomerAggregate.Repository
{
    public interface ICustomerRepository:IBaseRepository<Customer, CustomerId>
    {
    }
}
