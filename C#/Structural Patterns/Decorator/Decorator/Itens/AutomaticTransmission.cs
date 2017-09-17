namespace Decorator
{
    public class AutomaticTransmission : CarDecorator
    {
        public AutomaticTransmission(Car car) 
            : base(car)
        {
            _name = "Automatic Transmission";
            _cost = 5000m;
        }
    }
}
