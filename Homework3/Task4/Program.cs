using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the month you were born (number)");
            //bool monthNumTrue = int.TryParse(Console.ReadLine(), out int monthNum);
            while (true)
            {
                Console.WriteLine("Please enter the month you were born (number)");
                bool monthNumTrue = int.TryParse(Console.ReadLine(), out int monthNum);

                if (monthNumTrue)
                {
                    switch (monthNum)
                    {
                        case 1:
                            Console.WriteLine("January");
                            break;
                        case 2:
                            Console.WriteLine("February");
                            break;
                        case 3:
                            Console.WriteLine("March");
                            break;
                        case 4:
                            Console.WriteLine("April");
                            break;
                        case 5:
                            Console.WriteLine("May");
                            break;
                        case 6:
                            Console.WriteLine("June");
                            break;
                        case 7:
                            Console.WriteLine("July");
                            break;
                        case 8:
                            Console.WriteLine("August");
                            break;
                        case 9:
                            Console.WriteLine("September");
                            break;
                        case 10:
                            Console.WriteLine("October");
                            break;
                        case 11:
                            Console.WriteLine("November");
                            break;
                        case 12:
                            Console.WriteLine("December");
                            break;
                        default:
                            Console.WriteLine("Sorry. No such month found. Press enter and try again");
                            Console.ReadLine();
                            continue;
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("You didn't write correct input. Press enter and try again");
                    Console.ReadLine();
                }
            }
        }
    }
}
