using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 10; i < 100; i++)
            {
                string numberString = Convert.ToString(i);
                if (Convert.ToInt32(numberString[0]) > Convert.ToInt32(numberString[1]))
                {
                    Console.WriteLine(Convert.ToInt32(numberString));
                }
               
            }
            Console.ReadLine();
        }
    }
}
