namespace Builder
{
    /// <summary>
    /// This method represents the concrete builder and contains 
    /// methods that will prepare the hamburger.
    /// </summary>
    public class KBarbecueHamburgerBuilder : HamburgerBuilder
    {
        /// <summary>
        /// This method defines the bread that will be used
        /// </summary>
        public override void PrepareBread()
        {
            _hamburger.Bread = "french bread";
        }

        /// <summary>
        /// This method defines the complements that will be used
        /// </summary>
        public override void PrepareComplement()
        {
            _hamburger.Complement = "cheese, mayonnaise, pea, lettuce and tomato";
        }

        /// <summary>
        /// This method defines the main ingredient that will be used
        /// </summary>
        public override void PrepareMain()
        {
            _hamburger.Main = "beef sliced";
        }

        /// <summary>
        /// This method defines final price for this hamburguer
        /// </summary>
        public override void SetPrice()
        {
            _hamburger.Price = 12m;
        }
    }
}
