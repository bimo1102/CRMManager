using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using MediatR;

namespace CRMManager.Application.Feartures.Customers.Command.Create
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = Customer.Create(request.Name, request.TaxNumber, request.Street);
            await _customerRepository.AddAsync(customer);
        }
    }
}
