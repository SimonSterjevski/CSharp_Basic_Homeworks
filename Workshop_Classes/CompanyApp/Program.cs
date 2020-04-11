using CompanyClasses;
using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager john = new Manager("John", "Brown");
            Manager bryn = new Manager("Bryn", "Ward");
            john.AddBonus(600);
            Console.WriteLine(john.GetSalary());
            Console.WriteLine("-----------------");
            SalesPerson mike = new SalesPerson("Mike", "Smith");
            mike.ExtendSuccessRevenue(1300);
            Console.WriteLine(mike.GetSalary());
            Console.WriteLine("-----------------");
            Contractor tim = new Contractor("Tim", "Jones", 160, 2.5, john);
            Contractor brook = new Contractor("Brook", "Hanks", 160, 2.5, john);
            Console.WriteLine(tim.GetSalary());
            Console.WriteLine("-----------------");
            Employee[] company = {
            brook, tim, bryn, john, mike};
            CEO luke = new CEO("Luke", "Redd", company);
            luke.AddSharesPrice(5);
            Console.WriteLine($"{luke.Role}:");
            luke.PrintInfo();
            Console.WriteLine($"Salary of {luke.Role} is {luke.GetSalary()}");
            luke.PrintEmployees();
            Console.ReadLine();
        }
    }
}
