using Strategy.Concrete;
using Strategy.Context;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Developer dev = new Developer();
            Intern intern = new Intern();

            InfoStaff inf1 = new InfoStaff(manager);
            InfoStaff inf2 = new InfoStaff(dev);
            InfoStaff inf3 = new InfoStaff(intern);

            Console.WriteLine("Manager salary in a month is {0} with {1} benefits", inf1.Salary(200), inf1.Benefits());
            Console.WriteLine("Dev salary in a month is {0} with {1} benefits", inf2.Salary(200), inf2.Benefits());
            Console.WriteLine("Intern salary in a month is {0} with {1} benefits", inf3.Salary(200), inf3.Benefits());
            Console.ReadKey();
        }
    }
}