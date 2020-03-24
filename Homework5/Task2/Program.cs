using System;

namespace Task2
{
    class Program
    {

        static string Sum(int num1, int num2)
        {
            return $@"The result is {num1 + num2}";
        }

        static string Subtract(int num1, int num2)
        {
            return $@"The result is {num1 - num2}";
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hi! This is a simple calculator. Please enter operator (+ or -)");
                string operation = Console.ReadLine();
                if (operation == "+" || operation == "-")
                {
                    Console.Clear();
                    Console.WriteLine("Now please insert two numbers");
                    while (true)
                    {
                        Console.Write("First number is: ");
                        bool ifValidFirst = int.TryParse(Console.ReadLine(), out int firstNumber);
                        if (ifValidFirst)
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.Write("Second number is: ");
                                bool ifValidSecond = int.TryParse(Console.ReadLine(), out int secondNumber);
                                if (ifValidSecond)
                                {
                                    if (operation == "+")
                                    {
                                        Console.Clear();
                                        Console.WriteLine(Sum(firstNumber, secondNumber));
                                        Console.ReadLine();
                                        
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(Subtract(firstNumber, secondNumber));
                                        Console.ReadLine();
                                        
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Error! Please press enter and insert valid number");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Error! Please press enter and insert valid number");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Please press enter and insert valid operator");
                    Console.ReadLine();
                }
            }
        }
    }
}
