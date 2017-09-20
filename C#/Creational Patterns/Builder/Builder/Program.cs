using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builders
            MeatHamburgerBuilder meatHambBuilder = new MeatHamburgerBuilder();
            KBarbecueHamburgerBuilder kBarbecueHambBuilder = new KBarbecueHamburgerBuilder();

            // Director
            Establishment establishment = new Establishment();
            establishment.Construct(meatHambBuilder);
            establishment.Construct(kBarbecueHambBuilder);

            // Product
            Hamburger mealMeatHamb = meatHambBuilder.GetMeal();
            Console.WriteLine(mealMeatHamb.Description);

            // Product
            Hamburger kBarbecueMeatHamb = kBarbecueHambBuilder.GetMeal();
            Console.WriteLine(kBarbecueMeatHamb.Description);
            Console.ReadKey();
        }
    }
}