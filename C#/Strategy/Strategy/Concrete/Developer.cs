using Strategy.Interface;

namespace Strategy.Concrete
{
    public class Developer : IStaff
    {
        private const decimal value = 30m;

        public int Benefits()
        {
            return 3;
        }

        public decimal Salary(int workedHours)
        {
            return value * workedHours;
        }
    }
}
