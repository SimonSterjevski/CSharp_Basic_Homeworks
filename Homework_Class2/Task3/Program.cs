using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            string num1 = (Console.ReadLine());
            string num2 = (Console.ReadLine());
            Console.WriteLine(num1 + ", " + num2);
            Console.ReadLine();
            string helper = num1;
            num1 = num2;
            num2 = helper;

            Console.WriteLine(num1 + ", " + num2);
            Console.ReadLine();
        }
    }
}
