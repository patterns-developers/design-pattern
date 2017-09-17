namespace Facade
{
    /// <summary>
    /// This class represent an union of properties that return 
    /// informations about the customer.
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }

        public int Code { get; set; }

        public Customer(int code)
        {
            Code = code;
            Name = $"Customer {code}";
        }
    }
}
