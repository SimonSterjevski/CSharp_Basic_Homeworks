using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class ElectricCar: Car
    {
        public int BatteryCapacityKm { get; set; }
        public int BatteryPercentage { get; set; }
        public void Recharge()
        {
            BatteryPercentage = 100;
            Console.WriteLine($"Battery was recharded. {BatteryPercentage}%");
        }
        public ElectricCar(): base(Enums.EngineTypes.Electric)
        {
            Console.WriteLine($"Engine type set to {EngineType}");
        }
        public void SetMaxSpeed(int speed)
        {
            MaxSpeedKmH = speed;
        }
        public override void Drive()
        {
            Console.WriteLine($"This {EngineType} car drives with maximum speed of {MaxSpeedKmH}");
        }
    }
}
