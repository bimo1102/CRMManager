using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Feartures.Customers.Command.Update
{
    public record UpdateCustomerCommand
    (
        int id,
        string Name,
        string TaxNumber,
        string Street
    ) : IRequest;
}
