using CompanyEnums;
using System;

namespace CompanyClasses
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        protected double Salary { get; set; }
        
        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, salary {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
