using System;

namespace Task2
{

    public class Dog
    {
       public string Name { get; set; }
       public string Race { get; set; }
       public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is now eating");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} is now playing");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is now chasing its tail");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Console.Write("Hello! Please insert your dog's name: ");
            myDog.Name = Console.ReadLine();
            Console.Write("Now insert the dog's race: ");
            myDog.Race = Console.ReadLine();
            Console.Write("Insert the color of your dog: ");
            myDog.Color = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{myDog.Name} is {myDog.Color} colored {myDog.Race} :)");
                Console.WriteLine($"What {myDog.Name} likes to do most? Please insert the number");
                Console.WriteLine("1) Eat");
                Console.WriteLine("2) Play");
                Console.WriteLine("3) Chase its tail");
                bool isNum = int.TryParse(Console.ReadLine(), out int number);
                if (!isNum || number < 1 || number > 3)
                {
                    Console.WriteLine("Please press enter and insert valid number!");
                    Console.ReadLine();
                } else
                {
                    switch (number) {
                        case 1:
                            myDog.Eat();
                            break;
                        case 2:
                            myDog.Play();
                            break;
                        case 3:
                            myDog.ChaseTail();
                            break;
                        default:
                            continue;
                    }
                    Console.ReadLine();
                    break;
                } 
            }
            
        }
    }
}
