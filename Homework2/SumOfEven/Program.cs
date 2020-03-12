using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 6 integer numbers");
            int[] firstArray = new int[6];
            for (int i = 0; i < firstArray.Length; i++)
            {
                bool checkIfInt = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (checkIfInt)
                {
                    firstArray[i] = parsedNum;
                }
                else
                {
                    Console.WriteLine("You entered wrong number. Please enter valid number");
                    i--;
                }
            }

            int sum = 0;

            for (int j = 0; j < firstArray.Length; j++)
            {
                if (firstArray[j] % 2 == 0)
                {
                    sum += firstArray[j];
                }
            }
            Console.WriteLine("The sum of all even numbers is " + sum);
            Console.ReadLine();
        }
    }
}
