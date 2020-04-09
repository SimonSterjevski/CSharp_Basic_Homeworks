using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Bicycle: WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }
        public void Ride()
        {
            Console.WriteLine($"The {Type} is now riding");
        }
        public Bicycle(): base("bicycle")
        {
            Console.WriteLine($"New {Type} was produced!");
        }
        public override void Repair()
        {
            Console.WriteLine("Brakes have been fixed");
        }
    }
}
