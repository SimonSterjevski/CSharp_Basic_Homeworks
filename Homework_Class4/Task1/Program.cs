using System;

namespace Task1
{
    class Program
    {

        static void Substrings(string greeting)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number");
                bool isValid = int.TryParse(Console.ReadLine(), out int n);
                if (isValid)
                {
                    if (n > 0 && n <= greeting.Length)
                    {
                        Console.Clear();
                        string newString = greeting.Substring(0, n);
                        Console.WriteLine(newString);
                        Console.WriteLine($"The new string has {newString.Length} characters");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Error! Please press enter and insert number bigger than 0 and smaller than {greeting.Length + 1}");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error! Please press enter and insert a number");
                    Console.ReadLine();
                }
            }

        }
        static void Main(string[] args)
        {
            Substrings("Hello from SEDC Codecademy v7.0");
          
        }
    }
}
