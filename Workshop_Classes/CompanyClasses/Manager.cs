using CompanyEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClasses
{
    public class Manager: Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = Roles.Manager;
            Salary = 800;
        }
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }
        public override double GetSalary()
        {
            return Salary += Bonus;
        }
    }
}
