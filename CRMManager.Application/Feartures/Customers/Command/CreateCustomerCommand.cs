using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Feartures.Customers.Command
{
    public record CreateCustomerCommand
    (
        String Name,
        string TaxName,
        string Street
    ):IRequest;
}
