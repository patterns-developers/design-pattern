namespace Decorator
{
    public class CarDecorator : Car
    {
        Car _car = null;
        protected string _name = "Undefined";
        protected decimal _cost = 0m;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override decimal Cost()
        {
            return _car.Cost() + _cost;
        }

        public override string Descrition()
        {
            return string.Format("{0}, more {1}", _car.Descrition(), _name);
        }
    }
}
