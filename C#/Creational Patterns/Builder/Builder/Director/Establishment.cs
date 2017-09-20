namespace Builder
{
    /// <summary>
    /// This class represent the Director in Builder Pattern. 
    /// It defines how the product will be constructed
    /// </summary>
    public class Establishment
    {
        /// <summary>
        /// This method defines how the hamburger will be constructed
        /// </summary>
        /// <param name="hamburger">This method receives the abstract 
        /// class HamburgerBuilder</param>
        public void Construct(HamburgerBuilder hamburger)
        {
            hamburger.PrepareBread();
            hamburger.PrepareMain();
            hamburger.PrepareComplement();
            hamburger.SetPrice();
        }
    }
}
