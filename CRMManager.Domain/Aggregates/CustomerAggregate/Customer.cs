using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Domain.Aggregates.CustomerAggregate
{
    public class Customer : Entity<CustomerId>
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string Street { get; set; }
        public Customer(string name, string taxNumber, string street)
        {
            Name = name;
            TaxNumber = taxNumber;
            Street = street;
        }
        public static Customer Create(string name, string taxNumber, string street)
        {
            return new Customer(name, taxNumber, street);
        }
        private Customer()
        {
            
        }
    }
}
