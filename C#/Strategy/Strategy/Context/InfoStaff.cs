using Strategy.Interface;

namespace Strategy.Context
{
    public class InfoStaff
    {
        IStaff _staff;

        public InfoStaff(IStaff staff)
        {
            _staff = staff;
        }

        public decimal Salary(int workedHours)
        {
            return _staff.Salary(workedHours);
        }

        public decimal Benefits()
        {
            return _staff.Benefits();
        }
    }
}
