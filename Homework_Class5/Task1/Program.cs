using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            DateTime threeDaysFromNow = currentDate.AddDays(3);
            DateTime monthFromNow = currentDate.AddMonths(1);
            DateTime yearAgo = currentDate.AddYears(-1).AddMonths(-2);
            Console.WriteLine(threeDaysFromNow);
            Console.WriteLine(monthFromNow);
            Console.WriteLine(monthFromNow.AddDays(3));
            Console.WriteLine(yearAgo);
            //Console.WriteLine(currentDate.Month);
            Console.WriteLine(currentDate.ToString("MMMM"));
            Console.WriteLine(currentDate.Year);

            Console.ReadLine();
        }
    }
}
