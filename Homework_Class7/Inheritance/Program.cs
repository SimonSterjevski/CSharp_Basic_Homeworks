using Classes;
using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle ghost = new Bicycle();
            ghost.Repair();
            ghost.Ride();
            Console.WriteLine("----------------------");
            ElectricCar tesla = new ElectricCar();
            tesla.BatteryPercentage = 45;
            tesla.SetMaxSpeed(140);
            tesla.Drive();
            tesla.Recharge();
            Console.WriteLine("----------------------");
            Console.ReadLine();
        }
    }
}
