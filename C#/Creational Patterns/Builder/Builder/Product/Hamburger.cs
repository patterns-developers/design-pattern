namespace Builder
{
    /// <summary>
    /// This class represents the product that will be created
    /// </summary>
    public class Hamburger
    {
        public decimal Price { get; set; }

        public string Bread { get; set; }

        public string Main { get; set; }

        public string Complement { get; set; }

        /// <summary>
        /// This property returns a string with informations about
        /// the bread, the main ingredient, complements and final price
        /// </summary>
        public string Description {
            get
            {
                return $"{Bread}, {Main}, {Complement} for {Price}";
            }
        }
    }
}
