using CRMManager.Application.Feartures.Customers.Command.Delete;
using CRMManager.Application.Feartures.Customers.Dtos;
using CRMManager.Application.Feartures.Customers.Queries.GetById;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Common.Mapping
{
    public class customerMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Customer, CustomerDto>()
                .Map(dest => dest.id, src => src.Id.Value);
            config.NewConfig<int, DeleteCustomerCommand>()
                .MapWith(src => new DeleteCustomerCommand(src));
            config.NewConfig<int, GetCustomerByIdQuery>()
                .MapWith(src => new GetCustomerByIdQuery(src));
        }
    }
}
