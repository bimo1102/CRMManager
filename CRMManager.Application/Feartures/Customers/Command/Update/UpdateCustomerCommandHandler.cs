using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Feartures.Customers.Command.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(CustomerId.Create(request.id));
            if(customer is not null)
            {
                customer.SetName(request.Name);
                customer.SetTaxNumber(request.TaxNumber);
                customer.SetStreet(request.Street);
                await _customerRepository.UpdateAsync(customer);
            }
        }
    }
}
