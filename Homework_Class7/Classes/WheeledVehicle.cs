using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class WheeledVehicle: Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }
        public virtual void Repair()
        {
            Console.WriteLine($"The vehicle was repaired");
        }
        public WheeledVehicle(string type)
        {
            Type = type;
        }
    }
}
