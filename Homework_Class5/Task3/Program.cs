using System;

namespace Task3
{

    public class Driver
    {
        public string Name { get; set; }
        public double Skill { get; set; }
    } 

    public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }
        public double CalculateSpeed(Driver driver)
        {
            return driver.Skill * Speed;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Driver bob = new Driver()
            {
                Name = "Bob",
                Skill = 8.1
            };
            Driver greg = new Driver()
            {
                Name = "Greg",
                Skill = 7.7
            };
            Driver jill = new Driver()
            {
                Name = "Jill",
                Skill = 8.7
            };
            Driver anne = new Driver()
            {
                Name = "Anne",
                Skill = 9.2
            };


            Car hyundai = new Car()
            {
                Model = "Hyundai",
                Speed = 195,
            };
            Car mazda = new Car()
            {
                Model = "Mazda",
                Speed = 215,
            };
            Car porsche = new Car()
            {
                Model = "Porsche",
                Speed = 265,
            };
            Car ferarri = new Car()
            {
                Model = "Ferarri",
                Speed = 280,
            };

            Car[] cars = { hyundai, mazda, porsche, ferarri };
            Driver[] drivers = { bob, greg, jill, anne };

            while (true)
            {
                Car[] carSelected = new Car[2];
                Driver[] driverSelected = new Driver[2];
                Console.Clear();
                Console.WriteLine("Welcome to the race!");
                for (int i = 1; i < 3; i++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Player {i}, please select a car");
                        for (int j = 0; j < cars.Length; j++)
                        {
                            if (carSelected[0] != cars[j])
                            {
                                Console.WriteLine($"{j + 1}) {cars[j].Model}");
                            }
                        }
                        bool isNum = int.TryParse(Console.ReadLine(), out int carNum);
                        if (isNum && carNum < 5 && carNum > 0 && carNum-1 != Array.IndexOf(cars, carSelected[0]))
                        {
                            carSelected[i - 1] = cars[carNum - 1];
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Now please select driver");
                                for (int l = 0; l < drivers.Length; l++)
                                {
                                    if (driverSelected[0] != drivers[l])
                                    {
                                        Console.WriteLine($"{l + 1}) {drivers[l].Name}");
                                    }
                                }
                                bool isNum1 = int.TryParse(Console.ReadLine(), out int driverNum);
                                if (isNum1 && driverNum < 5 && driverNum > 0 && driverNum - 1 != Array.IndexOf(drivers, driverSelected[0]))
                                {
                                    driverSelected[i - 1] = drivers[driverNum - 1];
                                    cars[carNum - 1].Driver = drivers[driverNum - 1];
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please press enter and insert valid number");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please press enter and insert valid number");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine(RaceCars(carSelected[0], carSelected[1]));
                Console.Write("Insert 'y' to race again, insert any other key to exit.");
                string playAgain = Console.ReadLine();
                if (playAgain == "y" || playAgain == "Y")
                {
                    continue;
                } else
                {
                    break;
                }
               
            }
        }
         static string RaceCars(Car firstCar, Car secondCar)
            {
                if (firstCar.CalculateSpeed(firstCar.Driver) > secondCar.CalculateSpeed(secondCar.Driver))
                {
                    return $@"Car number 1 ({firstCar.Model}) drived by {firstCar.Driver.Name} was faster with max speed of {firstCar.Speed} km\h !!!";
                }
                else
                {
                    return $@"Car number 1 ({secondCar.Model}) drived by {secondCar.Driver.Name} was faster with max speed of {secondCar.Speed} km\h !!!";
                }

            }
    }
}
