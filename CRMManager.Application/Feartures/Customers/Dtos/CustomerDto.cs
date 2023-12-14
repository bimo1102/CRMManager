using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Application.Feartures.Customers.Dtos
{
    public record CustomerDto
    (
        int id,
        string Name,
        string TaxNumber,
        string Street
    );
}
