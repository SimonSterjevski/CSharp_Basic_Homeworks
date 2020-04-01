using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 numbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The average number is " + (num1 + num2 + num3 + num4) / 4);
            Console.ReadLine();
        }
    }
}
