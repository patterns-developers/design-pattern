namespace Facade
{
    /// <summary>
    /// This class represent an union of methods that verify 
    /// informations about customer.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Represent a method that verify in database the money limit of customer.
        /// </summary>
        /// <param name="custumer">Informations about customer</param>
        /// <returns>Limit available for credit</returns>
        public decimal CheckLimit(Customer customer)
        {
            return 100m;
        }
    }
}
