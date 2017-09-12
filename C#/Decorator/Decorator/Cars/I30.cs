namespace Decorator
{
    public class I30 : Car
    {
        private string _name = "i30";
        private decimal _cost = 50000m;

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
