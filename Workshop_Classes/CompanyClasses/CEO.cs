using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClasses
{
    public class CEO: Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public CEO(string name, string surname, Employee[] workers)
        {
            FirstName = name;
            LastName = surname;
            Salary = 2100;
            Shares = 2500;
            Employees = workers;
            Role = CompanyEnums.Roles.CEO;
        }
        public void AddSharesPrice(double amount)
        {
            SharesPrice = amount;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee man in Employees)
            {
                Console.WriteLine($"{man.FirstName} {man.LastName} ({man.Role})");
            }
        }
        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
