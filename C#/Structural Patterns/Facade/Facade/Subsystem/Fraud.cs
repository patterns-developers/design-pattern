namespace Facade
{
    /// <summary>
    /// This class is an union of methods that verify in databases, possibles frauds.
    /// </summary>
    public class Fraud
    {
        /// <summary>
        /// This method verify in a database if the customer have problem with frauds.
        /// </summary>
        /// <param name="customer">Informations about customer</param>
        /// <returns>Return true if customer doesn't have problems</returns>
        public bool CheckInfo(Customer customer)
        {
            return true;
        }
    }
}
