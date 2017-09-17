using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Making the car called i30 with optionals
            Car i30 = new I30();
            i30 = new AutomaticTransmission(i30);
            i30 = new AirConditioning(i30);
            Console.WriteLine("Description: {0}. Cost: {1}", i30.Descrition(), i30.Cost());
            #endregion

            #region Making the car called Ix35 with all optionals
            Car ix35 = new Ix35();
            ix35 = new AutomaticTransmission(ix35);
            ix35 = new AirConditioning(ix35);
            ix35 = new Alarm(ix35);
            Console.WriteLine("Description: {0}. Cost: {1}", ix35.Descrition(), ix35.Cost());
            #endregion

            Console.ReadKey();
        }
    }
}