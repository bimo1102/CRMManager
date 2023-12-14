using CRMManager.Application.Feartures.Customers.Command.Create;
using CRMManager.Application.Feartures.Customers.Command.Delete;
using CRMManager.Application.Feartures.Customers.Command.Update;
using CRMManager.Application.Feartures.Customers.Queries.GetById;
using CRMManager.Application.Feartures.Customers.Queries.ListAll;
using CRMManager.Contracts.Requests.Customer;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CustomerController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListAllCustomersQuery();
            var result = await _mediator.Send(query);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public async Task<IActionResult> GetById(int id)
        {
            var query = _mapper.Map<GetCustomerByIdQuery>(id);
            var result = await _mediator.Send(query);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create(CreateCustomerRequest createCustomerRequest)
        {
            var command = _mapper.Map<CreateCustomerCommand>(createCustomerRequest);
            await _mediator.Send(command);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok();
        }
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Update(UpdateCustomerRequest updateCustomerRequest)
        {
            var command = _mapper.Map<UpdateCustomerCommand>(updateCustomerRequest);
            await _mediator.Send(command);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = _mapper.Map<DeleteCustomerCommand>(id);
            await _mediator.Send(command);   
            return Ok();
        }
    }
}
