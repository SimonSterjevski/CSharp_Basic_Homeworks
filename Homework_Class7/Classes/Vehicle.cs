using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model} ");
        }
    }
}
