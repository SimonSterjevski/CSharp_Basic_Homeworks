using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 6 integer numbers");
            int[] firstArray = new int[6];
            int sum = 0;
            for (int i = 1; i <= firstArray.Length; i++)
            {
                Console.WriteLine("Enter number " + i);
                bool checkIfInt = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (checkIfInt)
                {
                    firstArray[i-1] = parsedNum;
                    if (firstArray[i-1] % 2 == 0)
                    {
                        sum += firstArray[i-1];
                    }
                }
                else
                {
                    Console.WriteLine("You entered wrong number. Please enter valid number");
                    i--;
                }
            }

            Console.WriteLine("The sum of all even numbers is " + sum);
            Console.ReadLine();
        }
    }
}
