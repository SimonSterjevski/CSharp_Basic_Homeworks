using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClasses
{
    public class Contractor: Employee
    {
        public int WorkHours { get; set; }
        public double PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public Contractor(string name, string surname, int workhours, double payperhour, Manager manager)
        {
            FirstName = name;
            LastName = surname;
            Salary = 400;
            WorkHours = workhours;
            PayPerHour = payperhour;
            Responsible = manager;
            Role = CompanyEnums.Roles.Contractor;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
    }
}
