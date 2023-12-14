using MediatR;

namespace CRMManager.Application.Feartures.Customers.Command.Create
{
    public record CreateCustomerCommand
    (
        string Name,
        string TaxNumber,
        string Street
    ) : IRequest;
}
