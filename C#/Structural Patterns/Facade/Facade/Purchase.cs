namespace Facade
{
    /// <summary>
    /// Facade class who makes the purchase
    /// </summary>
    public class Purchase
    {
        Customer _customer;
        Credit _credit;
        Fraud _fraud;

        /// <summary>
        /// Load subsystens
        /// </summary>
        /// <param name="codeCustomer">Code used to load customer informations</param>
        public Purchase(int codeCustomer)
        {
            _customer = new Customer(codeCustomer);
            _credit = new Credit();
            _fraud = new Fraud();
        }

        /// <summary>
        /// Method responsible for verify informations and makes the purchase
        /// </summary>
        /// <returns></returns>
        public bool Buy()
        {
            if (_fraud.CheckInfo(_customer) && _credit.CheckLimit(_customer) > 50)
                return true;

            return false;
        }
    }
}
