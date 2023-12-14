using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MediatR;


namespace CRMManager.Application.Feartures.Customers.Command.Delete
{
    public class DeletecustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public DeletecustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerRepository.DeleteAsync(CustomerId.Create(request.Id));
        }
    }
}
