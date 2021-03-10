using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TegahEmployee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal _salary;


        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0)
                    _salary = value;
            }
        }

    }
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Taiwo", "Oladotun", 50000M);
            Employee employee2 = new Employee("Tegah", "Tewogbade", 160000M);

            Console.WriteLine("Employee1 Name is: {0} {1}", employee1.FirstName, employee1.LastName);
            Console.WriteLine("Employee1 Salary is: N{0}", employee1.Salary);
            employee1.Salary = employee1.Salary * 12;
            Console.WriteLine("Employee1 yearly salary is: N{0}", employee1.Salary);

            Console.WriteLine("Employee2 Name is: {0} {1}", employee2.FirstName, employee2.LastName);
            Console.WriteLine("Employee2 Salary is: N{0}", employee2.Salary);
            employee2.Salary = employee2.Salary * 12;
            Console.WriteLine("Employee2 yearly salary is: N{0}", employee2.Salary);


            Console.WriteLine();
            Console.WriteLine("After 10% increase");

            employee1.Salary = employee1.Salary * 1.1m;
            employee2.Salary = employee2.Salary * 1.1m;

            Console.WriteLine("Employee1 new Salary is: N{0}", employee1.Salary);
            Console.WriteLine("Employee2 new Salary is: N{0}", employee2.Salary);


            Console.ReadLine();
        }
    }
}
