using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car: WheeledVehicle
    {
        public EngineTypes EngineType { get; set; }
        public int FuelConsuptionPer100Km { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeedKmH { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {Type} is driving");
        }
        public Car(): base("Car")
        {
            Console.WriteLine(Type);
        }

        public override void Repair()
        {
            Console.WriteLine("Alternator was changed");
        }
        public Car(EngineTypes enginetype): base("Car")
        {
            EngineType = enginetype;
        }
    }
}
