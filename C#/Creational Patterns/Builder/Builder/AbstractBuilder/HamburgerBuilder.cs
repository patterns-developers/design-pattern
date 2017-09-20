namespace Builder
{
    /// <summary>
    /// This abstract class will be extended by the concrete classes
    /// </summary>
    public abstract class HamburgerBuilder
    {
        protected Hamburger _hamburger;

        public HamburgerBuilder()
        {
            _hamburger = new Hamburger();
        }

        public abstract void PrepareBread();
        public abstract void PrepareMain();
        public abstract void PrepareComplement();
        public abstract void SetPrice();

        public Hamburger GetMeal()
        {
            return _hamburger;
        }
    }
}
