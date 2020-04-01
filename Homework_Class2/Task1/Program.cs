using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please enter two numbers");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select operator (+, -, *, /)");
            string operation = Console.ReadLine();
            switch (operation) {
                case "+": 
                 Console.WriteLine(firstNum + secondNum);
                    break;
                case "-":
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case "*":
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Error");
                    } else
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                    break;
                default:
                    Console.WriteLine("The operation can't be executed");
                    break;
            }
            Console.ReadLine();
        }
    }
}
