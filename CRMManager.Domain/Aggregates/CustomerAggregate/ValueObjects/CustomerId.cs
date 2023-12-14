
namespace CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects
{
    public class CustomerId
    {
        public int Value { get; private set; }
        private CustomerId(int value)
        {
            Value = value;
        }
        public static CustomerId Create(int value)
        {
            return new CustomerId(value);
        }
        private CustomerId()
        {

        }
    }
}
