using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Models;

namespace CRMManager.Domain.Aggregates.CustomerAggregate
{
    public class Customer : Entity<CustomerId>
    {
        public string Name { get; private set; }
        public string TaxNumber { get; private set; }
        public string Street { get; private set; }
        private Customer(string name, string taxNumber, string street)
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
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetTaxNumber(string  taxNumber)
        {
            TaxNumber = taxNumber;
        }
        public void SetStreet(string street)
        {
            Street = street;
        }
    }
}
