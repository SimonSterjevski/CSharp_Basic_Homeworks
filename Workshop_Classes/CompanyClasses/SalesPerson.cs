using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClasses
{
    public class SalesPerson: Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = 600;
            Role = CompanyEnums.Roles.Sales;
        }
        public void ExtendSuccessRevenue(int revenue)
        {
            SuccessSaleRevenue = revenue;
        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue < 2001)
            {
                return Salary + 500;
            } else if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue < 5001)
            {
                return Salary + 800;
            } else
            {
                return Salary + 2000;
            }  
        }
    }
}
