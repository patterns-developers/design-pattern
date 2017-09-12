namespace Decorator
{
    public class AirConditioning : CarDecorator
    {
        public AirConditioning(Car car) : 
            base(car)
        {
            _name = "Air Conditioning";
            _cost = 2500m;
        }
    }
}
