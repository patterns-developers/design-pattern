using Strategy.Interface;

namespace Strategy.Concrete
{
    public class Intern : IStaff
    {
        private const decimal value = 5m;

        public int Benefits()
        {
            return 1;
        }

        public decimal Salary(int workedHours)
        {
            return value * workedHours;
        }
    }
}
