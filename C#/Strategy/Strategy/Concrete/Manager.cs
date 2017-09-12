using Strategy.Interface;

namespace Strategy.Concrete
{
    public class Manager : IStaff
    {
        private const decimal value = 50m;

        public int Benefits()
        {
            return 5;
        }

        public decimal Salary(int workedHours)
        {
            return value * workedHours;
        }
    }
}
