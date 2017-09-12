namespace Decorator
{
    public class Ix35 : Car
    {
        private string _name = "Ix35";
        private decimal _cost = 80000m;

        public override decimal Cost()
        {
            return _cost;
        }

        public override string Descrition()
        {
            return _name;
        }
    }
}
