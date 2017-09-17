namespace Decorator
{
    public class Alarm : CarDecorator
    {
        public Alarm(Car car) 
            : base(car)
        {
            _name = "Alarm";
            _cost = 1000m;
        }
    }
}
