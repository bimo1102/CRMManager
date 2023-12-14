using CRMManager.Application.Feartures.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using MapsterMapper;
using MediatR;

namespace CRMManager.Application.Feartures.Customers.Queries.ListAll
{
    public class ListAllCustomersQueryhandler : IRequestHandler<ListAllCustomersQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public ListAllCustomersQueryhandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> Handle(ListAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<CustomerDto>>(await _customerRepository.GetAllAsync());
        }
    }
}
