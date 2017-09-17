using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the algorithm with facade pattern
            Purchase purchase = new Purchase(1);
            if (purchase.Buy())
            {
                Console.WriteLine("Purchase realized with successful!");
            }
            else
            {
                Console.WriteLine("Purchase failed");
            }
            Console.ReadKey();
        }
    }
}